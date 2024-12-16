using System;
using System.Runtime.InteropServices;

namespace JsNative
{
    public abstract class JsNative
    {
        // The UUID of the JavaScript object, used to keep a reference to the object.
        private string _uuid;
        public string Uuid
        {
            get => _uuid ?? (_uuid = CreateJs());
            internal set => _uuid = value;
        }
        // The JavaScript library used to interact with the JavaScript object instance.
        internal IJsNativeLib _jsNativeLib;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsNative"/> class.
        /// </summary>
        /// <param name="uuid">The UUID string used to lookup a reference to the JavaScript instance of the object.</param>
        /// <param name="jsNativeLib">(Optional) The JavaScript library used to interact with the JavaScript object instance. Defaults to an internal implementation.</param>
        public JsNative(string uuid = null, IJsNativeLib jsNativeLib = null)
        {
            Uuid = uuid;
            _jsNativeLib = jsNativeLib ?? new JsNativeLib();
        }

        ~JsNative()
        {
            RemoveReference();
        }

#if UNITY_WEBGL && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void JS_jsNative_removeReference(string instanceUUID);
#else
        private static void JS_jsNative_removeReference(string instanceUUID)
        {
            // empty implementation for Unity Editor stub
        }
#endif

        /// <summary>
        /// Removes the reference to the JavaScript object instance with the specified UUID. The object associated with the
        /// UUID will no longer be accessible and allow the garbage collector to clean it up if possible.
        /// </summary>
        protected void RemoveReference() => JS_jsNative_removeReference(Uuid);

        /// <summary>
        /// Creates a JavaScript representation of the object. Virtual to allow derived classes to implement custom
        /// creation behavior (e.g. an array needs to be created differently from an arbitrary object)
        /// </summary>
        /// <returns>The UUID of the created object</returns>
        protected virtual string CreateJs() => CreateObject();

        /// <summary>
        /// Creates an empty JavaScript object and returns its string UUID
        /// </summary>
        /// <returns>The UUID of the created object</returns>
        protected string CreateObject() => _jsNativeLib.CreateObject();

        /// <summary>
        /// Creates an empty JavaScript array and returns its string UUID
        /// </summary>
        /// <returns>The UUID of the created array</returns>
        protected string CreateArray() => _jsNativeLib.CreateArray();

        /// <summary>
        /// Retrieves the string value of a member with the specified name.
        /// </summary>
        /// <param name="memberName">The name of the member to retrieve the string value for.</param>
        /// <returns>The string value of the specified member.</returns>
        protected string GetMemberString(string memberName) => _jsNativeLib.GetMemberString(Uuid, memberName);

        /// <summary>
        /// Sets the value of a member with the specified name to the given string value.
        /// </summary>
        /// <param name="memberName">The name of the member to set.</param>
        /// <param name="value">The string value to set.</param>
        protected void SetMemberString(string memberName, string value) => _jsNativeLib.SetMemberString(Uuid, memberName, value);

        /// <summary>
        /// Retrieves the string value of a JSON-serializable object member with the specified name.
        /// </summary>
        /// <param name="memberName">The name of the member to retrieve the string value for.</param>
        /// <returns>The string value of the specified member.</returns>
        protected string GetMemberJsonSerializable(string memberName)
            => _jsNativeLib.GetMemberJsonSerializable(Uuid, memberName);

        /// <summary>
        /// Sets the value of a JSON-serializable object member with the specified name to the given value.
        /// </summary>
        /// <param name="memberName">The name of the member to set.</param>
        /// <param name="value">The string value to set.</param>
        protected void SetMemberJsonSerializable(string memberName, string value)
            => _jsNativeLib.SetMemberJsonSerializable(Uuid, memberName, value);

        /// <summary>
        /// Retrieves a double number value of a member with the specified name.
        /// </summary>
        /// <param name="memberName">The name of the member to retrieve the value from.</param>
        /// <returns>The double number value of the member.</returns>
        protected double GetMemberNumber(string memberName) => _jsNativeLib.GetMemberNumber(Uuid, memberName);

        /// <summary>
        /// Sets the value of a member with the specified name to the given double value.
        /// </summary>
        /// <param name="memberName">The name of the member to set.</param>
        /// <param name="value">The double value to set.</param>
        protected void SetMemberNumber(string memberName, double value) => _jsNativeLib.SetMemberNumber(Uuid, memberName, value);

        /// <summary>
        /// Gets the nullable double value of a member with the specified name.
        /// </summary>
        /// <param name="memberName">The name of the member to retrieve the nullable double value from.</param>
        /// <returns>The nullable double value of the specified member.</returns>
        protected double? GetMemberNullableNumber(string memberName) => _jsNativeLib.GetMemberNullableNumber(Uuid, memberName);

        /// <summary>
        /// Sets the value of a member with the specified name to the given nullable double value.
        /// </summary>
        /// <param name="memberName">The name of the member to set.</param>
        /// <param name="value">The nullable double value to set.</param>
        protected void SetMemberNullableNumber(string memberName, double? value) => _jsNativeLib.SetMemberNullableNumber(Uuid, memberName, value);

        /// <summary>
        /// Retrieves a boolean value from a member with the specified name.
        /// </summary>
        /// <param name="memberName">The name of the member to retrieve the boolean value from.</param>
        /// <returns>The boolean value of the specified member.</returns>
        protected bool GetMemberBoolean(string memberName) => _jsNativeLib.GetMemberBoolean(Uuid, memberName);

        /// <summary>
        /// Sets the value of a boolean member in the JavaScript object.
        /// </summary>
        /// <param name="memberName">The name of the member to set.</param>
        /// <param name="value">The boolean value to set.</param>
        protected void SetMemberBoolean(string memberName, bool value) => _jsNativeLib.SetMemberBoolean(Uuid, memberName, value);

        /// <summary>
        /// Retrieves the UUID of the member object with the specified name. The caller is responsible for creating an
        /// instance of a <see cref="JsNative"/> class using the UUID so that the reference is properly managed.
        /// </summary>
        /// <param name="memberName">The name of the member object.</param>
        /// <returns>The UUID of the member object's reference.</returns>
        protected string GetMemberReference(string memberName) => _jsNativeLib.GetMemberReference(Uuid, memberName);

        /// <summary>
        /// Sets the value of a member object in the JsNative instance.
        /// </summary>
        /// <param name="memberName">The name of the member object.</param>
        /// <param name="value">The JsNative instance to set as the member reference.</param>
        protected void SetMemberReference(string memberName, JsNative value) => _jsNativeLib.SetMemberReference(Uuid, memberName, value?.Uuid);
    }
}
