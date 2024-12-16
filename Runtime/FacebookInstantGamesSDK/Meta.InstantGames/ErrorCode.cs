namespace Meta.InstantGames
{
    /// <summary>
    /// Error codes that may be returned by the Instant Games API
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// Ads are being loaded too frequently.
        /// </summary>
        ADS_FREQUENT_LOAD,
        /// <summary>
        /// We were not able to serve ads to the current user. This can happen if the user has opted out of interest-based ads on their device, or if we do not have ad inventory to show for that user.
        /// </summary>
        ADS_NO_FILL,
        /// <summary>
        /// Attempted to show an ad that has not been loaded successfully.
        /// </summary>
        ADS_NOT_LOADED,
        /// <summary>
        /// There are too many concurrent ad instances. Load and show existing ad instances before creating new ones.
        /// </summary>
        ADS_TOO_MANY_INSTANCES,
        /// <summary>
        /// The analytics API experienced a problem while attempting to post an event.
        /// </summary>
        ANALYTICS_POST_EXCEPTION,
        /// <summary>
        /// ARENAS_NOT_FOUND
        /// </summary>
        ARENAS_NOT_FOUND,
        /// <summary>
        /// CAMERA_EFFECT_NOT_FOUND
        /// </summary>
        CAMERA_EFFECT_NOT_FOUND,
        /// <summary>
        /// [Deprecated] - The client requires an update to access the feature that returned this result. If this result is returned on web, it means the feature is not supported by the web client yet. Deprecated in favor of CLIENT_UNSUPPORTED_OPERATION in v5.0 and above
        /// </summary>
        CLIENT_REQUIRES_UPDATE,
        /// <summary>
        /// The client does not support the current operation. This may be due to lack of support on the client version or platform, or because the operation is not allowed for the game or player.
        /// </summary>
        CLIENT_UNSUPPORTED_OPERATION,
        /// <summary>
        /// DUPLICATE_POST
        /// </summary>
        DUPLICATE_POST,
        /// <summary>
        /// GAMING_SQUAD_NOT_FOUND
        /// </summary>
        GAMING_SQUAD_NOT_FOUND,
        /// <summary>
        /// GROUP_NOT_LINKED
        /// </summary>
        GROUP_NOT_LINKED,
        /// <summary>
        /// The requested operation is invalid for the current game state. This may include requests that violate limitations, such as exceeding storage thresholds, or are not available in a certain state, such as making a context-specific request in a solo context.
        /// </summary>
        INVALID_OPERATION,
        /// <summary>
        /// The parameter(s) passed to the API are invalid. Could indicate an incorrect type, invalid number of arguments, or a semantic issue (for example, passing an unserializable object to a serializing function).
        /// </summary>
        INVALID_PARAM,
        /// <summary>
        /// No leaderboard with the requested name was found. Either the leaderboard does not exist yet, or the name did not match any registered leaderboard configuration for the game.
        /// </summary>
        LEADERBOARD_NOT_FOUND,
        /// <summary>
        /// Attempted to write to a leaderboard that's associated with a context other than the one the game is currently being played in.
        /// </summary>
        LEADERBOARD_WRONG_CONTEXT,
        /// <summary>
        /// LIVE_MATCH_NOT_FOUND
        /// </summary>
        LIVE_MATCH_NOT_FOUND,
        /// <summary>
        /// LIVE_STREAMS_NOT_FOUND
        /// </summary>
        LIVE_STREAMS_NOT_FOUND,
        /// <summary>
        /// The client experienced an issue with a network request. This is likely due to a transient issue, such as the player's internet connection dropping.
        /// </summary>
        NETWORK_FAILURE,
        /// <summary>
        /// PAGE_NOT_LINKED
        /// </summary>
        PAGE_NOT_LINKED,
        /// <summary>
        /// The client has not completed setting up payments or is not accepting payments API calls.
        /// </summary>
        PAYMENTS_NOT_INITIALIZED,
        /// <summary>
        /// PAYMENTS_OPERATION_FAILURE
        /// </summary>
        PAYMENTS_OPERATION_FAILURE,
        /// <summary>
        /// Represents a rejection due an existing request that conflicts with this one. For example, we will reject any calls that would surface a Facebook UI when another request that depends on a Facebook UI is pending.
        /// </summary>
        PENDING_REQUEST,
        /// <summary>
        /// Some APIs or operations are being called too often. This is likely due to the game calling a particular API an excessive amount of times in a very short period. Reducing the rate of requests should cause this error to go away.
        /// </summary>
        RATE_LIMITED,
        /// <summary>
        /// The game attempted to perform a context switch into the current context.
        /// </summary>
        SAME_CONTEXT,
        /// <summary>
        /// TOURNAMENT_NOT_FOUND
        /// </summary>
        TOURNAMENT_NOT_FOUND,
        /// <summary>
        /// An unknown or unspecified issue occurred. This is the default error code returned when the client does not specify a code.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// The user made a choice that resulted in a rejection. For example, if the game calls up the Context Switch dialog and the player closes it, this error code will be included in the promise rejection.
        /// </summary>
        USER_INPUT,
        /// <summary>
        /// VIDEO_NOT_FOUND
        /// </summary>
        VIDEO_NOT_FOUND
    }
}
