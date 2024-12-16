using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Represents an instance of an ad.
    /// </summary>
    public partial class AdInstance : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of AdInstance
        /// </summary>
        public AdInstance() : base() { }

        private AdInstance(string instanceUUID) : base(instanceUUID) { }

        internal static AdInstance FromJs(string uuid)
        {
            return new AdInstance(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern string JS_AdInstance_getPlacementID(string instanceUUID);

        [DllImport("__Internal")]
        private static extern void JS_AdInstance_loadAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_AdInstance_showAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        #else

        private static string JS_AdInstance_getPlacementID(string instanceUUID)
            => "fake value from stub implementation";

        private static void JS_AdInstance_loadAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_AdInstance_showAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        #endif

        /// <summary>
        /// Return the Audience Network placement ID of this ad instance.
        /// </summary>
        /// <returns>The Audience Network placement ID of this ad instance.</returns>
        public string getPlacementID()
        {
            return JS_AdInstance_getPlacementID(Uuid);
        }

        /// <summary>
        /// Preload the ad. The returned <see cref="Runtime.WebTask"/> resolves when the preload completes, and rejects if it failed. Exceptions: ADS_FREQUENT_LOAD, ADS_NO_FILL, INVALID_PARAM, NETWORK_FAILURE
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the ad is preloaded.</returns>
        public Runtime.WebTask loadAsync()
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_AdInstance_loadAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Present the ad. The returned <see cref="Runtime.WebTask"/> resolves when user finished watching the ad, and rejects if it failed to present or was closed during the ad. Exceptions: ADS_NOT_LOADED, INVALID_PARAM, NETWORK_FAILURE, INVALID_OPERATION, RATE_LIMITED, USER_INPUT
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the user finishes watching the ad.</returns>
        public Runtime.WebTask showAsync()
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_AdInstance_showAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }
    }
}
