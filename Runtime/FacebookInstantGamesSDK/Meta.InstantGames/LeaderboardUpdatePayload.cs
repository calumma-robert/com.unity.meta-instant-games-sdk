namespace Meta.InstantGames
{
    /// <summary>
    /// Represents a leaderboard update for FBInstant.updateAsync.
    /// </summary>
    public partial class LeaderboardUpdatePayload : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of LeaderboardUpdatePayload
        /// </summary>
        /// <param name="action">For a leaderboard update, this should be 'LEADERBOARD'. text. By default we will use a localized 'Play Now' as the button text.</param>
        /// <param name="name">The name of the leaderboard to feature in the update.</param>
        /// <param name="text">Optional text message. If not specified, a localized fallback message will be provided instead.</param>
        public LeaderboardUpdatePayload(UpdateAction action, string name, string text = null)
        {
            Action = action;
            Name = name;
            Text = text;
        }

        /// <summary>
        /// For a leaderboard update, this should be 'LEADERBOARD'. text. By default we will use a localized 'Play Now' as the button text.
        /// </summary>
        public UpdateAction Action
        {
            get => (UpdateAction) System.Enum.Parse(typeof(UpdateAction), GetMemberString("action"));
            private set => SetMemberString("action", value.ToString());
        }

        /// <summary>
        /// The name of the leaderboard to feature in the update.
        /// </summary>
        public string Name
        {
            get => GetMemberString("name");
            private set => SetMemberString("name", value);
        }

        /// <summary>
        /// Optional text message. If not specified, a localized fallback message will be provided instead.
        /// </summary>
        public string Text
        {
            get => GetMemberString("text");
            private set => SetMemberString("text", value);
        }
    }
}
