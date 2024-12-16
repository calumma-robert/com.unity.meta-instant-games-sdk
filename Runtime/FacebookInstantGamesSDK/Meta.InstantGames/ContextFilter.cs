namespace Meta.InstantGames
{
    /// <summary>
    /// A filter that may be applied to a Context Choose operation. 'NEW_CONTEXT_ONLY' - Prefer to only surface contexts the game has not been played in before. 'INCLUDE_EXISTING_CHALLENGES' - Include the 'Existing Challenges' section, which surfaces actively played-in contexts that the player is a part of. 'NEW_PLAYERS_ONLY' - In sections containing individuals, prefer people who have not played the game.
    /// </summary>
    public enum ContextFilter
    {
        /// <summary>
        /// Prefer to only surface contexts the game has not been played in before.
        /// </summary>
        NEW_CONTEXT_ONLY,
        /// <summary>
        /// Include the "Existing Challenges" section, which surfaces actively played-in contexts that the player is a part of.
        /// </summary>
        INCLUDE_EXISTING_CHALLENGES,
        /// <summary>
        /// In sections containing individuals, prefer people who have not played the game.
        /// </summary>
        NEW_PLAYERS_ONLY
    }
}
