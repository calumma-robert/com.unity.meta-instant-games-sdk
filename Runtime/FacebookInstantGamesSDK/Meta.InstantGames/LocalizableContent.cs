namespace Meta.InstantGames
{
    /// <summary>
    /// Represents a string with localizations and a default value to fall back on.
    /// </summary>
    public partial class LocalizableContent : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of LocalizableContent
        /// </summary>
        /// <param name="defaultValue">The default value of the string to use if the viewer's locale is not a key in the localizations object.</param>
        /// <param name="localizations">Specifies what string to use for viewers in each locale. See https://lookaside.facebook.com/developers/resources/?id=FacebookLocales.xml for a complete list of supported locale values.</param>
        public LocalizableContent(string defaultValue, LocalizationsDict localizations)
        {
            Default = defaultValue;
            Localizations = localizations;
        }

        /// <summary>
        /// The default value of the string to use if the viewer's locale is not a key in the localizations object.
        /// </summary>
        public string Default
        {
            get => GetMemberString("default");
            private set => SetMemberString("default", value);
        }

        private LocalizationsDict _localizations;
        /// <summary>
        /// Specifies what string to use for viewers in each locale. See https://lookaside.facebook.com/developers/resources/?id=FacebookLocales.xml for a complete list of supported locale values.
        /// </summary>
        public LocalizationsDict Localizations
        {
            get => _localizations;
            private set
            {
                _localizations = value;
                SetMemberReference("localizations", value);
            }
        }
    }
}
