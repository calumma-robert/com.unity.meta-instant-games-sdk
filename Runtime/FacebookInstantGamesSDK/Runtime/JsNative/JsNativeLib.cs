using System.Runtime.InteropServices;

namespace JsNative
{
    /// <summary>
    /// An implementation of the <see cref="IJsNativeLib"/> interface. This implementation relies on externally defined
    /// functionality provided as C functions via emscripten's JavaScript library functionality.
    /// </summary>
    public class JsNativeLib : IJsNativeLib
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        /* The following methods are implemented in the JavaScript library, exposed as C functions via emscripten. */
        [DllImport("__Internal")]
        private static extern string JS_jsNative_createObject();
        [DllImport("__Internal")]
        private static extern string JS_jsNative_createArray();
        [DllImport("__Internal")]
        private static extern string JS_jsNative_getMemberString(string instanceUUID, string memberName);
        [DllImport("__Internal")]
        private static extern void JS_jsNative_setMemberString(string instanceUUID, string memberName, string memberValue);
        [DllImport("__Internal")]
        private static extern string JS_jsNative_getMemberJsonSerializable(string instanceUUID, string memberName);
        [DllImport("__Internal")]
        private static extern void JS_jsNative_setMemberJsonSerializable(string instanceUUID, string memberName, string memberValue);
        [DllImport("__Internal")]
        private static extern double JS_jsNative_getMemberNumber(string instanceUUID, string memberName);
        [DllImport("__Internal")]
        private static extern void JS_jsNative_setMemberNumber(string instanceUUID, string memberName, double memberValue);
        [DllImport("__Internal")]
        // Must return a double because JS -> C# does not allow marshalling of nullable types
        private static extern double JS_jsNative_getMemberNullableNumber(string instanceUUID, string memberName);
        [DllImport("__Internal")]
        // Must accept a double because C# -> JS does not allow marshalling of nullable types
        private static extern void JS_jsNative_setMemberNullableNumber(string instanceUUID, string memberName, double memberValue);
        [DllImport("__Internal")]
        private static extern bool JS_jsNative_getMemberBoolean(string instanceUUID, string memberName);
        [DllImport("__Internal")]
        private static extern void JS_jsNative_setMemberBoolean(string instanceUUID, string memberName, bool memberValue);
        [DllImport("__Internal")]
        private static extern string JS_jsNative_getMemberReference(string instanceUUID, string memberName);
        [DllImport("__Internal")]
        private static extern void JS_jsNative_setMemberReference(string instanceUUID, string memberName, string memberValue);
#else
        private static readonly string stubString = "fake value from stub implementation";
        private static string JS_jsNative_createObject() => stubString;
        private static string JS_jsNative_createArray() => stubString;
        private static string JS_jsNative_getMemberString(string instanceUUID, string memberName) => stubString;
        private static void JS_jsNative_setMemberString(string instanceUUID, string memberName, string memberValue)
        {
            // empty implementation for Unity Editor stub
        }
        private static string JS_jsNative_getMemberJsonSerializable(string instanceUUID, string memberName) => "{}";
        private static void JS_jsNative_setMemberJsonSerializable(string instanceUUID, string memberName, string memberValue)
        {
            // empty implementation for Unity Editor stub
        }
        private static double JS_jsNative_getMemberNumber(string instanceUUID, string memberName) => 1;
        private static void JS_jsNative_setMemberNumber(string instanceUUID, string memberName, double memberValue)
        {
            // empty implementation for Unity Editor stub
        }
        // Must return a double because JS -> C# does not allow marshalling of nullable types
        private static double JS_jsNative_getMemberNullableNumber(string instanceUUID, string memberName) => double.NaN;
        // Must accept a double because C# -> JS does not allow marshalling of nullable types
        private static void JS_jsNative_setMemberNullableNumber(string instanceUUID, string memberName, double memberValue)
        {
            // empty implementation for Unity Editor stub
        }
        private static bool JS_jsNative_getMemberBoolean(string instanceUUID, string memberName) => false;
        private static void JS_jsNative_setMemberBoolean(string instanceUUID, string memberName, bool memberValue)
        {
            // empty implementation for Unity Editor stub
        }
        private static string JS_jsNative_getMemberReference(string instanceUUID, string memberName) => stubString;
        private static void JS_jsNative_setMemberReference(string instanceUUID, string memberName, string memberValue)
        {
            // empty implementation for Unity Editor stub
        }
#endif

        /// <inheritdoc/>
        public string CreateObject() => JS_jsNative_createObject();

        /// <inheritdoc/>
        public string CreateArray() => JS_jsNative_createArray();

        /// <inheritdoc/>
        public string GetMemberString(string instanceUUID, string memberName) => JS_jsNative_getMemberString(instanceUUID, memberName);

        /// <inheritdoc/>
        public void SetMemberString(string instanceUUID, string memberName, string memberValue) => JS_jsNative_setMemberString(instanceUUID, memberName, memberValue);

        /// <inheritdoc/>
        public string GetMemberJsonSerializable(string instanceUUID, string memberName) => JS_jsNative_getMemberJsonSerializable(instanceUUID, memberName);

        /// <inheritdoc/>
        public void SetMemberJsonSerializable(string instanceUUID, string memberName, string memberValue) => JS_jsNative_setMemberJsonSerializable(instanceUUID, memberName, memberValue);

        /// <inheritdoc/>
        public double GetMemberNumber(string instanceUUID, string memberName) => JS_jsNative_getMemberNumber(instanceUUID, memberName);

        /// <inheritdoc/>
        public void SetMemberNumber(string instanceUUID, string memberName, double memberValue) => JS_jsNative_setMemberNumber(instanceUUID, memberName, memberValue);

        /// <inheritdoc/>
        public double? GetMemberNullableNumber(string instanceUUID, string memberName)
        {
            var result = JS_jsNative_getMemberNullableNumber(instanceUUID, memberName);
            return double.IsNaN(result) ? (double?) null : result;
        }

        /// <inheritdoc/>
        public void SetMemberNullableNumber(string instanceUUID, string memberName, double? memberValue) =>
            JS_jsNative_setMemberNullableNumber(instanceUUID, memberName, memberValue ?? double.NaN);

        /// <inheritdoc/>
        public bool GetMemberBoolean(string instanceUUID, string memberName) => JS_jsNative_getMemberBoolean(instanceUUID, memberName);

        /// <inheritdoc/>
        public void SetMemberBoolean(string instanceUUID, string memberName, bool memberValue) => JS_jsNative_setMemberBoolean(instanceUUID, memberName, memberValue);

        /// <inheritdoc/>
        public string GetMemberReference(string instanceUUID, string memberName) => JS_jsNative_getMemberReference(instanceUUID, memberName);

        /// <inheritdoc/>
        public void SetMemberReference(string instanceUUID, string memberName, string memberUUID) => JS_jsNative_setMemberReference(instanceUUID, memberName, memberUUID);
    }
}
