using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Container class for the API
    /// </summary>
    public class Sdk
    {
        private Meta.InstantGames.FBInstant _instance;

#if UNITY_WEBGL && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern string JS_FBInstant();
#else
        private static string JS_FBInstant() => "fake value from stub implementation";
#endif

        /// <summary>
        /// The root object for the API
        /// </summary>
        public Meta.InstantGames.FBInstant FBInstant
        {
            get
            {
                if (_instance is null)
                {
                    var uuid = JS_FBInstant();
                    _instance = Meta.InstantGames.FBInstant.FromJs(uuid);
                }
                return _instance;
            }
        }
    }
}
