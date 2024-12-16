using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Contains functions and properties related to instant tournaments.
    /// </summary>
    public partial class Tournaments : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of Tournaments
        /// </summary>
        public Tournaments() : base() { }

        private Tournaments(string instanceUUID) : base(instanceUUID) { }

        internal static Tournaments FromJs(string uuid)
        {
            return new Tournaments(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern void JS_Tournaments_createAsync(
            string instanceUUID,
            string payloadUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Tournaments_postScoreAsync(
            string instanceUUID,
            double score,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Tournaments_shareAsync(
            string instanceUUID,
            string payloadUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Tournaments_joinAsync(
            string instanceUUID,
            string tournamentID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Tournaments_getTournamentsAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        #else

        private static void JS_Tournaments_createAsync(
            string instanceUUID,
            string payloadUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_Tournaments_postScoreAsync(
            string instanceUUID,
            double score,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_Tournaments_shareAsync(
            string instanceUUID,
            string payloadUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_Tournaments_joinAsync(
            string instanceUUID,
            string tournamentID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_Tournaments_getTournamentsAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        #endif

        /// <summary>
        /// Opens the tournament creation dialog if the player is not currently in a tournament session.Exceptions: INVALID_PARAM, INVALID_OPERATION, DUPLICATE_POST, NETWORK_FAILURE
        /// </summary>
        /// <param name="payload">Tournament creation options</param>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> containing a <see cref="Meta.InstantGames.Tournament"/>.</returns>
        public async Runtime.WebTask<Tournament> createAsync(CreateTournamentPayload payload)
        {
            var payloadUuid = payload.Uuid;

            var instanceUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Tournaments_createAsync(Uuid, payloadUuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return Tournament.FromJs(instanceUuid);
        }

        /// <summary>
        /// Posts a player's score to Facebook. This API should only be called within a tournament context at the end of an activity (example: when the player doesn't have "lives" to continue the game). This API will be rate-limited when called too frequently. Scores posted using this API should be consistent and comparable across game sessions. For example, if Player A achieves 200 points in a session, and Player B achieves 320 points in a session, those two scores should be generated from activities where the scores are fair to be compared and ranked against each other. Returns a promise that resolves when the score post is completed. Exceptions: INVALID_PARAM, TOURNAMENT_NOT_FOUND, NETWORK_FAILURE
        /// </summary>
        /// <param name="score">An integer value representing the player's score at the end of an activity.</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the score post is completed.</returns>
        public Runtime.WebTask postScoreAsync(double score)
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Tournaments_postScoreAsync(Uuid, score, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Opens the reshare tournament dialog if the player is currently in a tournament sessionExceptions: INVALID_OPERATION, TOURNAMENT_NOT_FOUND, NETWORK_FAILURE
        /// </summary>
        /// <param name="payload">Specifies share content</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves if the tournament is shared, or rejects otherwise.</returns>
        public Runtime.WebTask shareAsync(ShareTournamentPayload payload)
        {
            var payloadUuid = payload.Uuid;

            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Tournaments_shareAsync(Uuid, payloadUuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Request a switch into a specific tournament context. If the player is not a participant of the tournament, or there are not any connected players participating in the tournament, this will reject. Otherwise, the promise will resolve when the game has switched into the specified context.Exceptions: INVALID_OPERATION, INVALID_PARAM, SAME_CONTEXT, NETWORK_FAILURE, USER_INPUT, TOURNAMENT_NOT_FOUND
        /// </summary>
        /// <param name="tournamentID">The Tournament ID of the desired context to switch into.</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the game has switched into the specified tournament context, or rejects otherwise.</returns>
        public Runtime.WebTask joinAsync(string tournamentID)
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Tournaments_joinAsync(Uuid, tournamentID, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Returns a list of eligible tournaments that can be surfaced in-game, including tournaments 1) the player has created; 2) the player is participating in; 3) the player's friends (who granted permission) are participating in. The instant tournaments returned are active. An instant tournament is expired if its end time is in the past. For each instant tournament, there is only one unique context ID linked to it, and that ID doesn't change. Exceptions: NETWORK_FAILURE, INVALID_OPERATION
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> containing a list of <see cref="Meta.InstantGames.Tournament"/>.</returns>
        public async Runtime.WebTask<Tournament[]> getTournamentsAsync()
        {
            var resultUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Tournaments_getTournamentsAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return JsNative.JsRefArray<Tournament>.FromJs(resultUuid).Values;
        }
    }
}
