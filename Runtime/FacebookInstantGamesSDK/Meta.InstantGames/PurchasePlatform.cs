namespace Meta.InstantGames
{
    /// <summary>
    /// Purchase Platforms that may be returned by subscriptions API, representing the platform by which the user made the purchase
    /// </summary>
    public enum PurchasePlatform
    {
        /// <summary>
        /// The user made the purchase on web
        /// </summary>
        FB,
        /// <summary>
        /// The user made the purchase in the Android apps
        /// </summary>
        GOOGLE,
        /// <summary>
        /// Not eligible
        /// </summary>
        APPLE,
        /// <summary>
        /// Not eligible
        /// </summary>
        OC,
        UNKNOWN
    }
}
