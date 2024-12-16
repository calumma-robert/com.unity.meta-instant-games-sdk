namespace Meta.InstantGames
{
    /// <summary>
    /// The payload for creating a tournament.
    /// </summary>
    public partial class CreateTournamentPayload : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of CreateTournamentPayload
        /// </summary>
        /// <param name="initialScore">An integer value representing the player's score which will be the first score in the tournament.</param>
        /// <param name="config">An object holding optional configurations for the tournament.</param>
        /// <param name="data">A blob of data to attach to the update. All game sessions launched from the update will be able to access this blob from the payload on the tournament. Must be less than or equal to 1000 characters when stringified.</param>
        public CreateTournamentPayload(double initialScore, CreateTournamentConfig config, string data = null)
        {
            InitialScore = initialScore;
            Config = config;
            Data = data;
        }

        /// <summary>
        /// An integer value representing the player's score which will be the first score in the tournament.
        /// </summary>
        public double InitialScore
        {
            get => GetMemberNumber("initialScore");
            private set => SetMemberNumber("initialScore", value);
        }

        private CreateTournamentConfig _config;
        /// <summary>
        /// An object holding optional configurations for the tournament.
        /// </summary>
        public CreateTournamentConfig Config
        {
            get => _config;
            private set
            {
                _config = value;
                SetMemberReference("config", value);
            }
        }

        /// <summary>
        /// A blob of data to attach to the update. All game sessions launched from the update will be able to access this blob from the payload on the tournament. Must be less than or equal to 1000 characters when stringified.
        /// </summary>
        public string Data
        {
            get => GetMemberJsonSerializable("data");
            private set => SetMemberJsonSerializable("data", value);
        }
    }
}
