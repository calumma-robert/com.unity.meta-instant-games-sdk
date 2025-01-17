using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;
using System.IO;

/// <summary>
/// The <c>AutoInitPreprocessor</c> class implements the <c>IPreprocessBuildWithReport</c> interface to handle
/// pre-build asset management for Unity projects with the Facebook Instant Games SDK package installed. It ensures
/// that, depending on the build configuration, the appropriate assets are present or removed from the local project
/// before the build process starts.
/// </summary>
public class AutoInitPreprocessor : IPreprocessBuildWithReport
{
    /// <summary>
    /// Gets the callback order for the pre-build process. This determines the order in which the pre-build steps are
    /// executed.
    /// </summary>
    public int callbackOrder => 0;

    /// <summary>
    /// The name of the package containing the assets to be copied.
    /// </summary>
    internal static readonly string packageName = "com.unity.meta-instant-games-sdk";

    /// <summary>
    /// The immutable package source path of the asset to be copied.
    /// </summary>
    internal static readonly string assetSource = $"Packages/{packageName}/Runtime/FacebookInstantGamesSDK/Init/init.js";

    /// <summary>
    /// The destination path for the asset within the Unity project. The 'pre' suffix allows the asset to be included
    /// automatically in the build process.
    /// </summary>
    internal static readonly string assetDestination = $"Assets/{packageName}/init.jspre";

    /// <summary>
    /// Executes the pre-build process. If the build target is Facebook Instant Games, it copies the auto-initializing
    /// pre-js asset to the destination directory. Otherwise, it deletes the asset if it exists to prevent timeouts from
    /// occurring outside the Facebook Instant Games platform.
    /// </summary>
    /// <param name="_">The build report; not used in this implementation.</param>
    public void OnPreprocessBuild(BuildReport _)
    {
#if UNITY_FACEBOOK_INSTANT_GAMES
        CopyInitScript();
#else
        RemoveInitScriptIfExists();
#endif
    }

    internal static void CopyInitScript()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(assetDestination));

        if (AssetDatabase.CopyAsset(assetSource, assetDestination))
        {
            AssetDatabase.Refresh();
        }
        else
        {
            var errorMessage = $"Failed to copy asset at {assetSource} to {assetDestination}. "
                + "\nThis asset is required when building for the Facebook Instant Games platform.";

            Debug.LogError(errorMessage);
        }
    }

    internal static void RemoveInitScriptIfExists()
    {
        if (AssetDatabase.DeleteAsset(assetDestination))
        {
            AssetDatabase.Refresh();
        }
    }
}
