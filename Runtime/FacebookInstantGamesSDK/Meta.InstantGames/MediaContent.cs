namespace Meta.InstantGames
{
    /// <summary>
    /// Specify how we could get the content for the media.
    /// </summary>
    public partial class MediaContent : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of MediaContent
        /// </summary>
        /// <param name="url">for the media that stores in the developers' server.</param>
        public MediaContent(string url)
        {
            Url = url;
        }

        /// <summary>
        /// for the media that stores in the developers' server.
        /// </summary>
        public string Url
        {
            get => GetMemberString("url");
            private set => SetMemberString("url", value);
        }
    }
}
