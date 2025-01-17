using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Represents information about a player who is connected to the current player.
    /// </summary>
    public partial class ConnectedPlayer : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of ConnectedPlayer
        /// </summary>
        public ConnectedPlayer() : base() { }

        private ConnectedPlayer(string instanceUUID) : base(instanceUUID) { }

        internal static ConnectedPlayer FromJs(string uuid)
        {
            return new ConnectedPlayer(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern string JS_ConnectedPlayer_getID(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_ConnectedPlayer_getName(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_ConnectedPlayer_getPhoto(string instanceUUID);

        #else

        private static string JS_ConnectedPlayer_getID(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_ConnectedPlayer_getName(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_ConnectedPlayer_getPhoto(string instanceUUID)
            => "fake value from stub implementation";

        #endif

        /// <summary>
        /// Get the id of the connected player.
        /// </summary>
        /// <returns>The ID of the connected player.</returns>
        public string GetID()
        {
            return JS_ConnectedPlayer_getID(Uuid);
        }

        /// <summary>
        /// Get the player's display name.
        /// </summary>
        /// <returns>The player's display name.</returns>
        public string GetName()
        {
            return JS_ConnectedPlayer_getName(Uuid);
        }

        /// <summary>
        /// Get the player's public profile photo.
        /// </summary>
        /// <returns>A url to the player's public profile photo.</returns>
        public string GetPhoto()
        {
            return JS_ConnectedPlayer_getPhoto(Uuid);
        }
    }
}
