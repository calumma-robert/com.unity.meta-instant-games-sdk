namespace Meta.InstantGames
{
    /// <summary>
    /// Specifies how the update should be delivered. This can be one of the following: 'IMMEDIATE' - The update should be posted immediately. 'LAST' - The update should be posted when the game session ends. The most recent update sent using the 'LAST' strategy will be the one sent. If no strategy is specified, we default to 'IMMEDIATE'.
    /// </summary>
    public enum UpdateStrategy
    {
        /// <summary>
        /// The update should be posted immediately.
        /// </summary>
        IMMEDIATE,
        /// <summary>
        /// The update should be posted when the game session ends. The most recent update sent using the 'LAST' strategy will be the one sent.
        /// </summary>
        LAST
    }
}
