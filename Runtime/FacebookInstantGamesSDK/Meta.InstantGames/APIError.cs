namespace Meta.InstantGames
{
    /// <summary>
    /// An API Error returned by the Instant Games SDK
    /// </summary>
    public class APIError : System.Exception
    {
        internal JsNative.JsNative JsNative { get; }

        internal APIError(string uuid)
        {
            JsNative = new JsNative.JsNative(uuid);
        }

        /// <summary>
        /// The relevant error code
        /// </summary>
        public ErrorCode Code
        {
            get
            {
                var code = JsNative.GetMemberString("code");
                return (ErrorCode) System.Enum.Parse(typeof(ErrorCode), code);
            }
        }

        /// <summary>
        /// A message describing the error
        /// </summary>
        public override string Message
        {
            get => JsNative.GetMemberString("message");
        }

        [Runtime.MonoPInvokeCallback]
        internal static void HandleVoidFailure(System.IntPtr taskPtr, string errorUuid) =>
            Runtime.WebTaskAsyncResult.HandleFailure(taskPtr, new APIError(errorUuid));

        [Runtime.MonoPInvokeCallback]
        internal static void HandleBoolFailure(System.IntPtr taskPtr, string errorUuid) =>
            HandleFailure<bool>(taskPtr, errorUuid);

        [Runtime.MonoPInvokeCallback]
        internal static void HandleNumberFailure(System.IntPtr taskPtr, string errorUuid) =>
            HandleFailure<double>(taskPtr, errorUuid);

        [Runtime.MonoPInvokeCallback]
        internal static void HandleStringFailure(System.IntPtr taskPtr, string errorUuid) =>
            HandleFailure<string>(taskPtr, errorUuid);

        private static void HandleFailure<T>(System.IntPtr taskPtr, string errorUuid) =>
            Runtime.WebTaskAsyncResult.HandleFailure<T>(taskPtr, new APIError(errorUuid));
    }
}
