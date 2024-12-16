namespace Meta.InstantGames
{
    /// <summary>
    /// Represents content used to reshare an Instant Tournament.
    /// </summary>
    public partial class ShareTournamentPayload : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of ShareTournamentPayload
        /// </summary>
        /// <param name="score">An integer value representing the player's latest score.</param>
        /// <param name="data">A blob of data to attach to the update. Must be less than or equal to 1000 characters when stringified.</param>
        public ShareTournamentPayload(double score, string data = null)
        {
            Score = score;
            Data = data;
        }

        /// <summary>
        /// An integer value representing the player's latest score.
        /// </summary>
        public double Score
        {
            get => GetMemberNumber("score");
            private set => SetMemberNumber("score", value);
        }

        /// <summary>
        /// A blob of data to attach to the update. Must be less than or equal to 1000 characters when stringified.
        /// </summary>
        public string Data
        {
            get => GetMemberJsonSerializable("data");
            private set => SetMemberJsonSerializable("data", value);
        }
    }
}
