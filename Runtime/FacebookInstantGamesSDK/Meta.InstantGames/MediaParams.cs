namespace Meta.InstantGames
{
    /// <summary>
    /// Represents the media payload used by custom update and custom share.
    /// </summary>
    public partial class MediaParams : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of MediaParams
        /// </summary>
        /// <param name="gif">if provided, the content should contain information for us to get the gif.</param>
        /// <param name="video">if provided, the content should contain information for us to get the video.</param>
        public MediaParams(MediaContent gif = null, MediaContent video = null)
        {
            Gif = gif;
            Video = video;
        }

        private MediaContent _gif;
        /// <summary>
        /// if provided, the content should contain information for us to get the gif.
        /// </summary>
        public MediaContent Gif
        {
            get => _gif;
            private set
            {
                _gif = value;
                SetMemberReference("gif", value);
            }
        }

        private MediaContent _video;
        /// <summary>
        /// if provided, the content should contain information for us to get the video.
        /// </summary>
        public MediaContent Video
        {
            get => _video;
            private set
            {
                _video = value;
                SetMemberReference("video", value);
            }
        }
    }
}
