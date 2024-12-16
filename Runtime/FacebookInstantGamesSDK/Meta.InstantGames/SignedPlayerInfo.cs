using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Represents information about the player along with a signature to verify that it indeed comes from Facebook.
    /// </summary>
    public partial class SignedPlayerInfo : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of SignedPlayerInfo
        /// </summary>
        public SignedPlayerInfo() : base() { }

        private SignedPlayerInfo(string instanceUUID) : base(instanceUUID) { }

        internal static SignedPlayerInfo FromJs(string uuid)
        {
            return new SignedPlayerInfo(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern string JS_SignedPlayerInfo_getPlayerID(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_SignedPlayerInfo_getSignature(string instanceUUID);

        #else

        private static string JS_SignedPlayerInfo_getPlayerID(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_SignedPlayerInfo_getSignature(string instanceUUID)
            => "fake value from stub implementation";

        #endif

        /// <summary>
        /// Get the id of the player.
        /// </summary>
        /// <returns>The ID of the player.</returns>
        public string getPlayerID()
        {
            return JS_SignedPlayerInfo_getPlayerID(Uuid);
        }

        /// <summary>
        /// A signature to verify this object indeed comes from Facebook. The string is base64url encoded and signed with an HMAC version of your App Secret, based on the OAuth 2.0 spec.
        /// </summary>
        /// <returns>The signature string.</returns>
        public string getSignature()
        {
            return JS_SignedPlayerInfo_getSignature(Uuid);
        }
    }
}
