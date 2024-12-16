namespace Meta.InstantGames
{
    /// <summary>
    /// Represents the type of the update action to perform. 'CUSTOM' - A custom update, with all content specified by the game. 'LEADERBOARD' - An update associated with an Instant Game leaderboard.
    /// </summary>
    public enum UpdateAction
    {
        /// <summary>
        /// A custom update, with all content specified by the game.
        /// </summary>
        CUSTOM,
        /// <summary>
        /// An update associated with an Instant Game leaderboard.
        /// </summary>
        LEADERBOARD
    }
}
