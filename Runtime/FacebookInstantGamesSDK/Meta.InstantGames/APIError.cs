namespace Meta.InstantGames
{
    /// <summary>
    /// Represents an exception thrown in JavaScript
    /// </summary>
    public class JsException : System.Exception
    {
        internal JsException(string message, ErrorCode code) : base(message)
        {
            Code = code;
        }

        /// <summary>
        /// The relevant error code
        /// </summary>
        public ErrorCode Code { get; }
    }

    /// <summary>
    /// An API Error returned by the Instant Games SDK
    /// </summary>
    public class APIError : JsNative.JsNative
    {
        internal APIError(string uuid) : base(uuid) { }

        /// <summary>
        /// Represents the underlying exception
        /// </summary>
        public JsException JsException => new JsException(Message.ToString(), Code);

        /// <summary>
        /// The relevant error code
        /// </summary>
        public ErrorCode Code
        {
            get
            {
                var code = GetMemberString("code");
                return (ErrorCode) System.Enum.Parse(typeof(ErrorCode), code);
            }
        }

        /// <summary>
        /// A message describing the error
        /// </summary>
        public string Message
        {
            get => GetMemberString("message");
        }

        [Runtime.MonoPInvokeCallback]
        internal static void HandleVoidFailure(System.IntPtr taskPtr, string errorUuid)
        {
            var error = new APIError(errorUuid);
            Runtime.WebTaskAsyncResult.HandleFailure(taskPtr, error.JsException);
        }

        [Runtime.MonoPInvokeCallback]
        internal static void HandleBoolFailure(System.IntPtr taskPtr, string errorUuid) => HandleFailure<bool>(taskPtr, errorUuid);

        [Runtime.MonoPInvokeCallback]
        internal static void HandleNumberFailure(System.IntPtr taskPtr, string errorUuid) => HandleFailure<double>(taskPtr, errorUuid);

        [Runtime.MonoPInvokeCallback]
        internal static void HandleStringFailure(System.IntPtr taskPtr, string errorUuid) => HandleFailure<string>(taskPtr, errorUuid);

        private static void HandleFailure<T>(System.IntPtr taskPtr, string errorUuid)
        {
            var error = new APIError(errorUuid);
            Runtime.WebTaskAsyncResult.HandleFailure<T>(taskPtr, error.JsException);
        }
    }
}
