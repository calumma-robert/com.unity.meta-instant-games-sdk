namespace Meta.InstantGames
{
    /// <summary>
    /// Represents the configurations used in creating an Instant Tournament.
    /// </summary>
    public partial class CreateTournamentConfig : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of CreateTournamentConfig
        /// </summary>
        /// <param name="title">Optional text title for the tournament.</param>
        /// <param name="image">Optional base64 encoded image that will be associated with the tournament and included in posts sharing the tournament.</param>
        /// <param name="scoreFormat">Optional input for the formatting of the scores in the tournament leaderboard. The options are 'NUMERIC' or 'TIME'. If not specified, the default is 'NUMERIC'.</param>
        /// <param name="sortOrder">Optional input for the ordering of which score is best in the tournament. The options are 'HIGHER_IS_BETTER' or 'LOWER_IS_BETTER'. If not specified, the default is 'HIGHER_IS_BETTER'.</param>
        /// <param name="endTime">Optional input for setting a custom end time for the tournament. The number passed in represents a unix timestamp. If not specified, the tournament will end one week after creation.</param>
        public CreateTournamentConfig(string title = null, string image = null, TournamentScoreFormat? scoreFormat = null, TournamentSortOrder? sortOrder = null, double? endTime = null)
        {
            Title = title;
            Image = image;
            ScoreFormat = scoreFormat;
            SortOrder = sortOrder;
            EndTime = endTime;
        }

        /// <summary>
        /// Optional text title for the tournament.
        /// </summary>
        public string Title
        {
            get => GetMemberString("title");
            private set => SetMemberString("title", value);
        }

        /// <summary>
        /// Optional base64 encoded image that will be associated with the tournament and included in posts sharing the tournament.
        /// </summary>
        public string Image
        {
            get => GetMemberString("image");
            private set => SetMemberString("image", value);
        }

        /// <summary>
        /// Optional input for the formatting of the scores in the tournament leaderboard. The options are 'NUMERIC' or 'TIME'. If not specified, the default is 'NUMERIC'.
        /// </summary>
        public TournamentScoreFormat? ScoreFormat
        {
            get
            {
                var value = GetMemberString("scoreFormat");

                if (value is null)
                {
                    return null;
                }
                else
                {
                    return (TournamentScoreFormat) System.Enum.Parse(typeof(TournamentScoreFormat), value);
                }
            }
            private set => SetMemberString("scoreFormat", value?.ToString());
        }

        /// <summary>
        /// Optional input for the ordering of which score is best in the tournament. The options are 'HIGHER_IS_BETTER' or 'LOWER_IS_BETTER'. If not specified, the default is 'HIGHER_IS_BETTER'.
        /// </summary>
        public TournamentSortOrder? SortOrder
        {
            get
            {
                var value = GetMemberString("sortOrder");

                if (value is null)
                {
                    return null;
                }
                else
                {
                    return (TournamentSortOrder) System.Enum.Parse(typeof(TournamentSortOrder), value);
                }
            }
            private set => SetMemberString("sortOrder", value?.ToString());
        }

        /// <summary>
        /// Optional input for setting a custom end time for the tournament. The number passed in represents a unix timestamp. If not specified, the tournament will end one week after creation.
        /// </summary>
        public double? EndTime
        {
            get => GetMemberNullableNumber("endTime");
            private set => SetMemberNullableNumber("endTime", value);
        }
    }
}
