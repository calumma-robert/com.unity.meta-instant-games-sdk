using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// The main entry point to the Facebook Instant Games SDK.
    /// </summary>
    public partial class FBInstant : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of FBInstant
        /// </summary>
        public FBInstant() : base() { }

        private FBInstant(string instanceUUID) : base(instanceUUID) { }

        internal static FBInstant FromJs(string uuid)
        {
            return new FBInstant(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_quit(string instanceUUID);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_initializeAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_startGameAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_createShortcutAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_performHapticFeedbackAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern string JS_FBInstant_getSupportedAPIs(string instanceUUID);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_getTournamentAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_updateAsync(
            string instanceUUID,
            string payloadUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_canCreateShortcutAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<bool> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_loadBannerAdAsync(
            string instanceUUID,
            string placementID,
            string bannerPosition,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_hideBannerAdAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_getInterstitialAdAsync(
            string instanceUUID,
            string placementID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_getRewardedVideoAsync(
            string instanceUUID,
            string placementID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_FBInstant_getRewardedInterstitialAsync(
            string instanceUUID,
            string placementID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern string JS_FBInstant_getLocale(string instanceUUID);

        [DllImport("__Internal")]
        private static extern string JS_FBInstant_getPlatform(string instanceUUID);

        #else

        private static void JS_FBInstant_quit(string instanceUUID)
            { }

        private static void JS_FBInstant_initializeAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_FBInstant_startGameAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_FBInstant_createShortcutAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_FBInstant_performHapticFeedbackAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static string JS_FBInstant_getSupportedAPIs(string instanceUUID)
            => "fake value from stub implementation";

        private static void JS_FBInstant_getTournamentAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_FBInstant_updateAsync(
            string instanceUUID,
            string payloadUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_FBInstant_canCreateShortcutAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<bool> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, false);

        private static void JS_FBInstant_loadBannerAdAsync(
            string instanceUUID,
            string placementID,
            string bannerPosition,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_FBInstant_hideBannerAdAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_FBInstant_getInterstitialAdAsync(
            string instanceUUID,
            string placementID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_FBInstant_getRewardedVideoAsync(
            string instanceUUID,
            string placementID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_FBInstant_getRewardedInterstitialAsync(
            string instanceUUID,
            string placementID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static string JS_FBInstant_getLocale(string instanceUUID)
            => "fake value from stub implementation";

        private static string JS_FBInstant_getPlatform(string instanceUUID)
            => "fake value from stub implementation";

        #endif

        private Context _context;
        /// <summary>
        /// Contains functions and properties related to the current game context.
        /// </summary>
        public Context Context
        {
            get
            {
                if (_context is null)
                {
                    var uuid = GetMemberReference("context");
                    _context = uuid == null ? null : Context.FromJs(uuid);
                }
                return _context;
            }
        }

        private Player _player;
        /// <summary>
        /// Contains functions and properties related to the current player.
        /// </summary>
        public Player Player
        {
            get
            {
                if (_player is null)
                {
                    var uuid = GetMemberReference("player");
                    _player = uuid == null ? null : Player.FromJs(uuid);
                }
                return _player;
            }
        }

        private Tournaments _tournament;
        /// <summary>
        /// Contains functions and properties related to tournaments.
        /// </summary>
        public Tournaments Tournament
        {
            get
            {
                if (_tournament is null)
                {
                    var uuid = GetMemberReference("tournament");
                    _tournament = uuid == null ? null : Tournaments.FromJs(uuid);
                }
                return _tournament;
            }
        }

        /// <summary>
        /// Quits the game.
        /// </summary>
        public void Quit()
        {
            JS_FBInstant_quit(Uuid);
        }

        /// <summary>
        /// Initializes the SDK library. This should be called before any other SDK functions.
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the SDK is ready to use.</returns>
        public Runtime.WebTask InitializeAsync()
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_FBInstant_initializeAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// This indicates that the game has finished initial loading and is ready to start. Context information will be up-to-date when the returned <see cref="Runtime.WebTask"/> resolves. Exceptions: INVALID_PARAM, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the game should start.</returns>
        public Runtime.WebTask StartGameAsync()
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_FBInstant_startGameAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Prompts the user to create a shortcut to the game if they are eligible to. Can only be called once per session. Exceptions: USER_INPUT, PENDING_REQUEST, CLIENT_REQUIRES_UPDATE, INVALID_OPERATION
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask"/>.</returns>
        public Runtime.WebTask CreateShortcutAsync()
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_FBInstant_createShortcutAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Requests and performs haptic feedback on supported devices. Exceptions: CLIENT_UNSUPPORTED_OPERATION, INVALID_OPERATION
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask"/> when haptic feedback was requested successfully.</returns>
        public Runtime.WebTask PerformHapticFeedbackAsync()
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_FBInstant_performHapticFeedbackAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Provides a list of API functions that are supported by the client. Note that these are the names from the JavaScript SDK. The corresponding C# property and method names begin with a capital letter.
        /// </summary>
        /// <returns>A list of API functions that the client explicitly supports.</returns>
        public string[] GetSupportedAPIs()
        {
            var arrayUuid = JS_FBInstant_getSupportedAPIs(Uuid);
            var array = JsNative.JsArray<string>.FromJs(arrayUuid);
            return array.Values;
        }

        /// <summary>
        /// Fetch the instant tournament out of the current context the user is playing. This will reject if there is no instant tournament link to the current context. The instant tournament returned can be either active or expired (An instant tournament is expired if its end time is in the past). For each instant tournament, there is only one unique context ID linked to it, and that ID doesn't change. Exceptions: PENDING_REQUEST, NETWORK_FAILURE, INVALID_OPERATION, TOURNAMENT_NOT_FOUND
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> containing a <see cref="Meta.InstantGames.Tournament"/>.</returns>
        public async Runtime.WebTask<Tournament> GetTournamentAsync()
        {
            var instanceUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_FBInstant_getTournamentAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return Meta.InstantGames.Tournament.FromJs(instanceUuid);
        }

        /// <summary>
        /// Informs Facebook of an update that occurred in the game. This will temporarily yield control to Facebook and Facebook will decide what to do based on what the update is. The returned <see cref="Runtime.WebTask"/> will resolve/reject when Facebook returns control to the game. Exceptions: INVALID_PARAM, PENDING_REQUEST, INVALID_OPERATION
        /// </summary>
        /// <param name="payload">A payload that describes the update</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when Facebook gives control back to the game.</returns>
        public Runtime.WebTask UpdateAsync(CustomUpdatePayload payload)
        {
            var payloadUuid = payload.Uuid;

            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_FBInstant_updateAsync(Uuid, payloadUuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Informs Facebook of an update that occurred in the game. This will temporarily yield control to Facebook and Facebook will decide what to do based on what the update is. The returned <see cref="Runtime.WebTask"/> will resolve/reject when Facebook returns control to the game. Exceptions: INVALID_PARAM, PENDING_REQUEST, INVALID_OPERATION
        /// </summary>
        /// <param name="payload">A payload that describes the update</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when Facebook gives control back to the game.</returns>
        public Runtime.WebTask UpdateAsync(LeaderboardUpdatePayload payload)
        {
            var payloadUuid = payload.Uuid;

            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_FBInstant_updateAsync(Uuid, payloadUuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Returns whether or not the user is eligible to have shortcut creation requested. Will return false if createShortcutAsync was already called this session or the user is ineligible for shortcut creation. Exceptions: PENDING_REQUEST, CLIENT_REQUIRES_UPDATE, INVALID_OPERATION
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves with true if the game can request the player create a shortcut to the game, and false otherwise</returns>
        public Runtime.WebTask<bool> CanCreateShortcutAsync()
        {
            return new Runtime.WebTask<bool>((System.IntPtr taskPtr) =>
                JS_FBInstant_canCreateShortcutAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleBoolFailure)
            );
        }

        /// <summary>
        /// Attempt to load or re-load a banner ad. Exceptions: RATE_LIMITED, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <param name="placementID">The placement ID that's been set up in your Audience Network settings.</param>
        /// <param name="bannerPosition">An optional parameter that sets the position of the banner to be "top" or "bottom." The default is a banner at the bottom of the screen.</param>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves after loading a banner ad, or rejects with an <see cref="Meta.InstantGames.APIError"/> if it couldn't be created.</returns>
        public Runtime.WebTask LoadBannerAdAsync(string placementID, string bannerPosition = "bottom")
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_FBInstant_loadBannerAdAsync(Uuid, placementID, bannerPosition, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Attempt to hide a banner ad. Exceptions: CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves after the ad is hidden.</returns>
        public Runtime.WebTask HideBannerAdAsync()
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_FBInstant_hideBannerAdAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure));
        }

        /// <summary>
        /// Attempt to create an instance of an interstitial ad. This instance can then be preloaded and presented. Exceptions: ADS_TOO_MANY_INSTANCES, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <param name="placementID">The placement ID that's been set up in your Audience Network settings.</param>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves with an <see cref="Meta.InstantGames.AdInstance"/>, or rejects with an <see cref="Meta.InstantGames.APIError"/> if it couldn't be created.</returns>
        public async Runtime.WebTask<AdInstance> GetInterstitialAdAsync(string placementID)
        {
            var instanceUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_FBInstant_getInterstitialAdAsync(Uuid, placementID, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return Meta.InstantGames.AdInstance.FromJs(instanceUuid);
        }

        /// <summary>
        /// Attempt to create an instance of rewarded video. This instance can then be preloaded and presented. Exceptions: ADS_TOO_MANY_INSTANCES, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <param name="placementID">The placement ID that's been set up in your Audience Network settings.</param>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves with an <see cref="Meta.InstantGames.AdInstance"/>, or rejects with an <see cref="Meta.InstantGames.APIError"/> if it couldn't be created.</returns>
        public async Runtime.WebTask<AdInstance> GetRewardedVideoAsync(string placementID)
        {
            var instanceUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_FBInstant_getRewardedVideoAsync(Uuid, placementID, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return Meta.InstantGames.AdInstance.FromJs(instanceUuid);
        }

        /// <summary>
        /// Attempt to create an instance of rewarded interstitial. This instance can then be preloaded and presented. Exceptions: ADS_TOO_MANY_INSTANCES, CLIENT_UNSUPPORTED_OPERATION
        /// </summary>
        /// <param name="placementID">The placement ID that's been set up in your Audience Network settings.</param>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> that resolves with an <see cref="Meta.InstantGames.AdInstance"/>, or rejects with an <see cref="Meta.InstantGames.APIError"/> if it couldn't be created.</returns>
        public async Runtime.WebTask<AdInstance> GetRewardedInterstitialAsync(string placementID)
        {
            var instanceUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_FBInstant_getRewardedInterstitialAsync(Uuid, placementID, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return Meta.InstantGames.AdInstance.FromJs(instanceUuid);
        }

        private Payments _payments;
        /// <summary>
        /// Contains functions and properties related to payments and purchases of game products.
        /// </summary>
        public Payments Payments
        {
            get
            {
                if (_payments is null)
                {
                    var uuid = GetMemberReference("payments");
                    _payments = uuid == null ? null : Payments.FromJs(uuid);
                }
                return _payments;
            }
        }

        /// <summary>
        /// The current locale. See https://lookaside.facebook.com/developers/resources/?id=FacebookLocales.xml for a complete list of supported locale values. Use this to determine what languages the current game should be localized with. The value will not be accurate until FBInstant.initializeAsync() resolves.
        /// </summary>
        /// <returns>The current locale.</returns>
        public string GetLocale()
        {
            return JS_FBInstant_getLocale(Uuid);
        }

        /// <summary>
        /// The platform on which the game is currently running. The value will always be null until FBInstant.initializeAsync() resolves.
        /// </summary>
        /// <returns>The current platform.</returns>
        public Platform? GetPlatform()
        {
            var platform = JS_FBInstant_getPlatform(Uuid);
            return System.Enum.TryParse(typeof(Platform), platform, out var result) ? (Platform?)result : null;
        }
    }
}
