using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Contains functions and properties related to the current player.
    /// </summary>
    public partial class Player : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of Player
        /// </summary>
        public Player() : base() { }

        private Player(string instanceUUID) : base(instanceUUID) { }

        internal static Player FromJs(string uuid)
        {
            return new Player(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern string JS_Player_getName(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_Player_getPhoto(string instanceUUID);

        [DllImport("__Internal")]
        private static extern void JS_Player_getConnectedPlayersAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Player_getDataAsync(
            string instanceUUID,
            string keysUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Player_setDataAsync(
            string instanceUUID,
            string data,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Player_getSignedPlayerInfoAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Player_subscribeBotAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Player_canSubscribeBotAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<bool> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Player_getASIDAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Player_getSignedASIDAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        #else

        private static string JS_Player_getName(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_Player_getPhoto(string instanceUUID)
            => "fake value from stub implementation";

        private static void JS_Player_getConnectedPlayersAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_Player_getDataAsync(
            string instanceUUID,
            string keysUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_Player_setDataAsync(
            string instanceUUID,
            string data,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_Player_getSignedPlayerInfoAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_Player_subscribeBotAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_Player_canSubscribeBotAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<bool> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, false);

        private static void JS_Player_getASIDAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_Player_getSignedASIDAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        #endif

        /// <summary>
        /// The player's localized display name. This function should not be called until FBInstant.initializeAsync() has resolved.
        /// </summary>
        /// <returns>The player's display name.</returns>
        public string GetName()
        {
            return JS_Player_getName(Uuid);
        }

        /// <summary>
        /// A url to the player's public profile photo. The photo will always be a square, and with dimensions of at least 200x200. When rendering it in the game, the exact dimensions should never be assumed to be constant. It's recommended to always scale the image to a desired size before rendering. The value will always be null until FBInstant.initializeAsync() resolves. WARNING: Due to CORS, using these photos in the game canvas can cause it to be tainted, which will prevent the canvas data from being extracted. To prevent this, set the cross-origin attribute of the images you use to 'anonymous'.
        /// </summary>
        /// <returns>A url to the player's public profile photo.</returns>
        public string GetPhoto()
        {
            return JS_Player_getPhoto(Uuid);
        }

        /// <summary>
        /// Fetches an array of ConnectedPlayer objects containing information about active players (people who played the game in the last 90 days) that are connected to the current player.Exceptions: NETWORK_FAILURE, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves with a list of <see cref="Meta.InstantGames.ConnectedPlayer"/>. NOTE: This function should not be called until FBInstant.initializeAsync() has resolved.</returns>
        public async Runtime.WebTask<ConnectedPlayer[]> GetConnectedPlayersAsync()
        {
            var resultUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Player_getConnectedPlayersAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return JsNative.JsRefArray<Meta.InstantGames.ConnectedPlayer>.FromJs(resultUuid).Values;
        }

        /// <summary>
        /// Retrieve data from the designated cloud storage of the current player. Please note that JSON objects stored as string values would be returned back as JSON objects. Returns a promise that resolves with an object which contains the current key-value pairs for each key specified in the input array, if they exist. Exceptions: INVALID_PARAM, NETWORK_FAILURE, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <param name="keys">An array of unique keys to retrieve data for</param>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves with an object which contains the current key-value pairs for each key specified in the input array, if they exist.</returns>
        public Runtime.WebTask<string> GetDataAsync(string[] keys)
        {
            var keysUuid = JsNative.JsArray<string>.FromCs(keys).Uuid;

            return new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Player_getDataAsync(Uuid, keysUuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );
        }

        /// <summary>
        /// Set data to be saved to the designated cloud storage of the current player. The game can store up to 1MB of data for each unique player.Exceptions: INVALID_PARAM, NETWORK_FAILURE, PENDING_REQUEST, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <param name="data">An object containing a set of key-value pairs that should be persisted to cloud storage. The object must contain only serializable values - any non-serializable values will cause the entire modification to be rejected.</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the input values are set. NOTE: The promise resolving does not necessarily mean that the input has already been persisted. Rather, it means that the data was valid and has been scheduled to be saved. It also guarantees that all values that were set are now available in player.getDataAsync.</returns>
        public Runtime.WebTask SetDataAsync(string data)
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Player_setDataAsync(Uuid, data, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Fetch the player's unique identifier along with a signature that verifies that the identifier indeed comes from Facebook without being tampered with. This function should not be called until FBInstant.initializeAsync() has resolved.Exceptions: NETWORK_FAILURE, CLIENT_UNSUPPORTED_OPERATION, INVALID_PARAM
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves with a <see cref="Meta.InstantGames.SignedPlayerInfo"/> object.</returns>
        public async Runtime.WebTask<SignedPlayerInfo> GetSignedPlayerInfoAsync()
        {
            var instanceUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Player_getSignedPlayerInfoAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return Meta.InstantGames.SignedPlayerInfo.FromJs(instanceUuid);
        }

        /// <summary>
        /// Request that the player subscribe the bot associated to the game. The API will reject if the subscription fails - else, the player will subscribe the game bot. Exceptions: INVALID_PARAM, CLIENT_REQUIRES_UPDATE, PENDING_REQUEST
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves if player successfully subscribed to the game bot, or rejects if request failed or player chose to not subscribe.</returns>
        public Runtime.WebTask SubscribeBotAsync()
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Player_subscribeBotAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Returns a promise that resolves with whether the player can subscribe to the game bot or not. Exceptions: RATE_LIMITED, CLIENT_UNSUPPORTED_OPERATION, INVALID_OPERATION
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> indicating whether a player can subscribe to the game bot or not. Developer can only call subscribeBotAsync() after checking canSubscribeBotAsync(), and the game will only be able to show the player their bot subscription dialog once per week.</returns>
        public Runtime.WebTask<bool> CanSubscribeBotAsync()
        {
            return new Runtime.WebTask<bool>((System.IntPtr taskPtr) =>
                JS_Player_canSubscribeBotAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleBoolFailure)
            );
        }

        /// <summary>
        /// A unique identifier for the player. This is the standard Facebook Application-Scoped ID which is used for all Graph API calls. If your game shares an AppID with a native game this is the ID you will see in the native game too.
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves with the player's unique identifier.</returns>
        public Runtime.WebTask<string> GetASIDAsync()
        {
            return new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Player_getASIDAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );
        }

        /// <summary>
        /// A unique identifier for the player. This is the standard Facebook Application-Scoped ID which is used for all Graph API calls. If your game shares an AppID with a native game this is the ID you will see in the native game too.
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves with a <see cref="Meta.InstantGames.SignedASID"/> object.</returns>
        public async Runtime.WebTask<SignedASID> GetSignedASIDAsync()
        {
            var instanceUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Player_getSignedASIDAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return Meta.InstantGames.SignedASID.FromJs(instanceUuid);
        }
    }
}
