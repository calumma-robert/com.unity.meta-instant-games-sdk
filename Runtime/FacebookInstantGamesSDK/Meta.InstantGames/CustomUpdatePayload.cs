namespace Meta.InstantGames
{
    /// <summary>
    /// Represents a custom update for FBInstant.updateAsync. Note that if localized content is not provided, a Facebook supplied localized string will be used for the call to action and text.The default string should always be in English.
    /// </summary>
    public partial class CustomUpdatePayload : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of CustomUpdatePayload
        /// </summary>
        /// <param name="action">For custom updates, this should be 'CUSTOM'.</param>
        /// <param name="template">ID of the template this custom update is using. Templates should be predefined in fbapp-config.json. See the [Bundle Config documentation] https://developers.facebook.com/docs/games/instant-games/bundle-config for documentation about fbapp-config.json.</param>
        /// <param name="text">A text message, or an object with the default text as the value of 'default' and another object mapping locale keys to translations as the value of 'localizations'.</param>
        /// <param name="cta">Optional call-to-action button text. By default we will use a localized 'Play' as the button text. To provide localized versions of your own call to action, pass an object with the default cta as the value of 'default' and another object mapping locale keys to translations as the value of 'localizations'.</param>
        /// <param name="image">Optional data URL of a base64 encoded image.</param>
        /// <param name="data">A blob of data to attach to the update. All game sessions launched from the update will be able to access this blob through FBInstant.getEntryPointData(). Must be less than or equal to 1000 characters when stringified.</param>
        /// <param name="strategy">Specifies how the update should be delivered. This can be one of the following: 'IMMEDIATE' - The update should be posted immediately. 'LAST' - The update should be posted when the game session ends. The most recent update sent using the 'LAST' strategy will be the one sent. If no strategy is specified, we default to 'IMMEDIATE'.</param>
        /// <param name="notification">Specifies notification setting for the custom update. This can be 'NO_PUSH' or 'PUSH', and defaults to 'NO_PUSH'. Use push notification only for updates that are high-signal and immediately actionable for the recipients. Also note that push notification is not always guaranteed, depending on user setting and platform policies.</param>
        public CustomUpdatePayload(UpdateAction action, string template, LocalizableContent text, LocalizableContent cta = null, string image = null, string data = null, UpdateStrategy? strategy = null, UpdateNotification? notification = null)
        {
            Action = action;
            Template = template;
            Text = text;
            Cta = cta;
            Image = image;
            Data = data;
            Strategy = strategy;
            Notification = notification;
        }

        /// <summary>
        /// For custom updates, this should be 'CUSTOM'.
        /// </summary>
        public UpdateAction Action
        {
            get => (UpdateAction) System.Enum.Parse(typeof(UpdateAction), GetMemberString("action"));
            private set => SetMemberString("action", value.ToString());
        }

        /// <summary>
        /// ID of the template this custom update is using. Templates should be predefined in fbapp-config.json. See the [Bundle Config documentation] https://developers.facebook.com/docs/games/instant-games/bundle-config for documentation about fbapp-config.json.
        /// </summary>
        public string Template
        {
            get => GetMemberString("template");
            private set => SetMemberString("template", value);
        }

        private LocalizableContent _text;
        /// <summary>
        /// A text message, or an object with the default text as the value of 'default' and another object mapping locale keys to translations as the value of 'localizations'.
        /// </summary>
        public LocalizableContent Text
        {
            get => _text;
            private set
            {
                _text = value;
                SetMemberReference("text", value);
            }
        }

        private LocalizableContent _cta;
        /// <summary>
        /// Optional call-to-action button text. By default we will use a localized 'Play' as the button text. To provide localized versions of your own call to action, pass an object with the default cta as the value of 'default' and another object mapping locale keys to translations as the value of 'localizations'.
        /// </summary>
        public LocalizableContent Cta
        {
            get => _cta;
            private set
            {
                _cta = value;
                SetMemberReference("cta", value);
            }
        }

        /// <summary>
        /// Optional data URL of a base64 encoded image.
        /// </summary>
        public string Image
        {
            get => GetMemberString("image");
            private set => SetMemberString("image", value);
        }

        /// <summary>
        /// A blob of data to attach to the update. All game sessions launched from the update will be able to access this blob through FBInstant.getEntryPointData(). Must be less than or equal to 1000 characters when stringified.
        /// </summary>
        public string Data
        {
            get => GetMemberJsonSerializable("data");
            private set => SetMemberJsonSerializable("data", value);
        }

        /// <summary>
        /// Specifies how the update should be delivered. This can be one of the following: 'IMMEDIATE' - The update should be posted immediately. 'LAST' - The update should be posted when the game session ends. The most recent update sent using the 'LAST' strategy will be the one sent. If no strategy is specified, we default to 'IMMEDIATE'.
        /// </summary>
        public UpdateStrategy? Strategy
        {
            get
            {
                var value = GetMemberString("strategy");

                if (value is null)
                {
                    return null;
                }
                else
                {
                    return (UpdateStrategy) System.Enum.Parse(typeof(UpdateStrategy), value);
                }
            }
            private set => SetMemberString("strategy", value?.ToString());
        }

        /// <summary>
        /// Specifies notification setting for the custom update. This can be 'NO_PUSH' or 'PUSH', and defaults to 'NO_PUSH'. Use push notification only for updates that are high-signal and immediately actionable for the recipients. Also note that push notification is not always guaranteed, depending on user setting and platform policies.
        /// </summary>
        public UpdateNotification? Notification
        {
            get
            {
                var value = GetMemberString("notification");

                if (value is null)
                {
                    return null;
                }
                else
                {
                    return (UpdateNotification) System.Enum.Parse(typeof(UpdateNotification), value);
                }
            }
            private set => SetMemberString("notification", value?.ToString());
        }
    }
}
