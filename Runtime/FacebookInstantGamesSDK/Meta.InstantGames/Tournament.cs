using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// An instant game tournament.
    /// </summary>
    public partial class Tournament : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of Tournament
        /// </summary>
        public Tournament() : base() { }

        private Tournament(string instanceUUID) : base(instanceUUID) { }

        internal static Tournament FromJs(string uuid)
        {
            return new Tournament(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern string JS_Tournament_getID(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_Tournament_getContextID(string instanceUUID);

        [DllImport("__Internal")]
        private static extern double JS_Tournament_getEndTime(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_Tournament_getTitle(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_Tournament_getPayload(string instanceUUID);

        #else

        private static string JS_Tournament_getID(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_Tournament_getContextID(string instanceUUID)
            => "fake value from stub implementation";

        private static double JS_Tournament_getEndTime(string instanceUUID)
            => 0;

        private static string JS_Tournament_getTitle(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_Tournament_getPayload(string instanceUUID)
            => "fake value from stub implementation";

        #endif

        /// <summary>
        /// The unique ID that is associated with this instant tournament.
        /// </summary>
        /// <returns>A string.</returns>
        public string getID()
        {
            return JS_Tournament_getID(Uuid);
        }

        /// <summary>
        /// The unique context ID that is associated with this instant tournament.
        /// </summary>
        /// <returns>A string.</returns>
        public string getContextID()
        {
            return JS_Tournament_getContextID(Uuid);
        }

        /// <summary>
        /// Timestamp when the instant tournament ends. If the end time is in the past, then the instant tournament is already finished and has expired.
        /// </summary>
        /// <returns>A number.</returns>
        public double getEndTime()
        {
            return JS_Tournament_getEndTime(Uuid);
        }

        /// <summary>
        /// Title of the tournament provided upon the creation of the tournament. This is an optional field that can be set by creating the tournament using the FBInstant.tournament.createAsync() API.
        /// </summary>
        /// <returns>A nullable string.</returns>
        public string getTitle()
        {
            return JS_Tournament_getTitle(Uuid);
        }

        /// <summary>
        /// Payload of the tournament provided upon the creation of the tournament. This is an optional field that can be set by creating the tournament using the FBInstant.tournament.createAsync() API. Returns null if none was provided.
        /// </summary>
        /// <returns>A nullable string.</returns>
        public string getPayload()
        {
            return JS_Tournament_getPayload(Uuid);
        }
    }
}
