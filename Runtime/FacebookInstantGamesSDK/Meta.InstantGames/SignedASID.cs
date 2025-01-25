using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Represents app-scoped user id of current player along with a signature to verify that it indeed comes from Facebook.
    /// </summary>
    public partial class SignedASID : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of SignedASID
        /// </summary>
        public SignedASID() : base() { }

        private SignedASID(string instanceUUID) : base(instanceUUID) { }

        internal static SignedASID FromJs(string uuid)
        {
            return new SignedASID(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern string JS_SignedASID_getASID(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_SignedASID_getSignature(string instanceUUID);

        #else

        private static string JS_SignedASID_getASID(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_SignedASID_getSignature(string instanceUUID)
            => "fake value from stub implementation";

        #endif

        /// <summary>
        /// Get the app-scoped user id of the player.
        /// </summary>
        /// <returns>The ID of the player</returns>
        public string GetASID()
        {
            return JS_SignedASID_getASID(Uuid);
        }

        /// <summary>
        /// A signature to verify this object indeed comes from Facebook. The string is base64url encoded and signed with an HMAC version of your App Secret, based on the OAuth 2.0 spec.
        /// </summary>
        /// <returns>The signature string.</returns>
        public string GetSignature()
        {
            return JS_SignedASID_getSignature(Uuid);
        }
    }
}
