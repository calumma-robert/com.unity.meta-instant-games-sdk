using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Represents information about a player who is in the context that the current player is playing in.
    /// </summary>
    public partial class ContextPlayer : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of ContextPlayer
        /// </summary>
        public ContextPlayer() : base() { }

        private ContextPlayer(string instanceUUID) : base(instanceUUID) { }

        internal static ContextPlayer FromJs(string uuid)
        {
            return new ContextPlayer(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern string JS_ContextPlayer_getID(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_ContextPlayer_getName(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_ContextPlayer_getPhoto(string instanceUUID);

        #else

        private static string JS_ContextPlayer_getID(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_ContextPlayer_getName(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_ContextPlayer_getPhoto(string instanceUUID)
            => "fake value from stub implementation";

        #endif

        /// <summary>
        /// Get the id of the context player.
        /// </summary>
        /// <returns>The ID of the context player.</returns>
        public string GetID()
        {
            return JS_ContextPlayer_getID(Uuid);
        }

        /// <summary>
        /// Get the player's localized display name.
        /// </summary>
        /// <returns>The player's localized display name.</returns>
        public string GetName()
        {
            return JS_ContextPlayer_getName(Uuid);
        }

        /// <summary>
        /// Get the player's public profile photo.
        /// </summary>
        /// <returns>A url to the player's public profile photo.</returns>
        public string GetPhoto()
        {
            return JS_ContextPlayer_getPhoto(Uuid);
        }
    }
}
