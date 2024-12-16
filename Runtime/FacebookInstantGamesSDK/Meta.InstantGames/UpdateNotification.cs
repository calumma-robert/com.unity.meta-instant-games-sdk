namespace Meta.InstantGames
{
    /// <summary>
    /// Specifies notification setting for the custom update. This can be 'NO_PUSH' or 'PUSH', and defaults to 'NO_PUSH'. Use push notification only for updates that are high-signal and immediately actionable for the recipients. Also note that push notification is not always guaranteed, depending on user setting and platform policies.
    /// </summary>
    public enum UpdateNotification
    {
        /// <summary>
        /// Don't push the notification.
        /// </summary>
        NO_PUSH,
        /// <summary>
        /// Push the notification if possible.
        /// </summary>
        PUSH
    }
}
