using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Contains functions and properties related to the current game context.
    /// </summary>
    public partial class Context : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of Context
        /// </summary>
        public Context() : base() { }

        private Context(string instanceUUID) : base(instanceUUID) { }

        internal static Context FromJs(string uuid)
        {
            return new Context(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern void JS_Context_switchAsync(
            string instanceUUID,
            string id,
            bool switchSilentlyIfSolo,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Context_chooseAsync(
            string instanceUUID,
            string optionsUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Context_createAsync(
            string instanceUUID,
            string suggestedPlayerIdsUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Context_getPlayersAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        #else

        private static void JS_Context_switchAsync(
            string instanceUUID,
            string id,
            bool switchSilentlyIfSolo,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_Context_chooseAsync(
            string instanceUUID,
            string optionsUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_Context_createAsync(
            string instanceUUID,
            string suggestedPlayerIdsUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_Context_getPlayersAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        #endif

        /// <summary>
        /// Request a switch into a specific context. If the player does not have permission to enter that context, or if the player does not provide permission for the game to enter that context, this will reject. Otherwise, the promise will resolve when the game has switched into the specified context. Exceptions: INVALID_PARAM, SAME_CONTEXT, NETWORK_FAILURE, USER_INPUT, PENDING_REQUEST, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <param name="id">ID of the desired context or the string SOLO to switch into a solo context.</param>
        /// <param name="switchSilentlyIfSolo">If switching into a solo context, set this to true to switch silently, with no confirmation dialog or toast. This only has an effect when switching into a solo context.</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the game has switched into the specified context, or rejects otherwise.</returns>
        public Runtime.WebTask SwitchAsync(string id, bool switchSilentlyIfSolo = false)
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Context_switchAsync(Uuid, id, switchSilentlyIfSolo, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Opens a context selection dialog for the player. If the player selects an available context, the client will attempt to switch into that context, and resolve if successful. Otherwise, if the player exits the menu or the client fails to switch into the new context, this function will reject. Exceptions: INVALID_PARAM, SAME_CONTEXT, NETWORK_FAILURE, USER_INPUT, PENDING_REQUEST, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <param name="options">An object specifying conditions on the contexts that should be offered.</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the game has switched into the context chosen by the user. Otherwise, the promise will reject (if the user cancels out of the dialog, for example).</returns>
        public Runtime.WebTask ChooseAsync(ContextOptions options = null)
        {
            var optionsUuid = options?.Uuid;

            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Context_chooseAsync(Uuid, optionsUuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Attempts to create a context between the current player and a specified player or a list of players. This API supports 3 use cases:1) When the input is a single playerID, it attempts to create or switch into a context between a specified player and the current player 2) When the input is a list of connected playerIDs, it attempts to create a context containing all the players 3) When there's no input, a friend picker will be loaded to ask the player to create a context with friends to play with For each of these cases, the returned <see cref="Runtime.WebTask"/> will reject if any of the players listed are not Connected Players of the current player, or if the player denies the request to enter the new context. Otherwise, the <see cref="Runtime.WebTask"/> will resolve when the game has switched into the new context. Exceptions: INVALID_PARAM, SAME_CONTEXT, NETWORK_FAILURE, USER_INPUT, PENDING_REQUEST, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <param name="suggestedPlayerIds">A list of game suggested playerIDs or a single suggested playerID or no input</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the game has switched into the new context, or rejects otherwise.</returns>
        public Runtime.WebTask CreateAsync(string[] suggestedPlayerIds = null)
        {
            var suggestedPlayerIdsUuid =
                suggestedPlayerIds != null && suggestedPlayerIds.Length != 0
                ? JsNative.JsArray<string>.FromCs(suggestedPlayerIds).Uuid
                : null;

            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Context_createAsync(Uuid, suggestedPlayerIdsUuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Gets an array of ContextPlayer objects containing information about active players in the current context (people who played the game in the current context in the last 90 days). This may include the current player. Exceptions: NETWORK_FAILURE, CLIENT_UNSUPPORTED_OPERATION, INVALID_OPERATION
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> containing an array of <see cref="Meta.InstantGames.ContextPlayer"/>.</returns>
        public async Runtime.WebTask<ContextPlayer[]> GetPlayersAsync()
        {
            var resultUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Context_getPlayersAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return JsNative.JsRefArray<Meta.InstantGames.ContextPlayer>.FromJs(resultUuid).Values;
        }
    }
}
