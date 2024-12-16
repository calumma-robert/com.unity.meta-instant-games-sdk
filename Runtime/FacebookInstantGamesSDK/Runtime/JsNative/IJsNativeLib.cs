namespace JsNative
{
    /// <summary>
    /// Provides a common interface for JavaScript objects referenced in C# code. Each method requires an `instanceUUID` to
    /// lookup the JavaScript object instance. Operations corresponding to the interface are then performed on that
    /// instance.
    /// </summary>
    public interface IJsNativeLib
    {
        /// <summary>
        /// Creates an empty JavaScript object and returns its string UUID
        /// </summary>
        /// <returns>The UUID of the created object</returns>
        string CreateObject();

        /// <summary>
        /// Creates an empty JavaScript array and returns its string UUID
        /// </summary>
        /// <returns>The UUID of the created array</returns>
        string CreateArray();

        /// <summary>
        /// Gets the value of the instance's member as a string.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <returns>The value of the member as a string.</returns>
        string GetMemberString(string instanceUUID, string memberName);

        /// <summary>
        /// Sets the value of the instance's member as a string.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <param name="memberValue">The value to set.</param>
        void SetMemberString(string instanceUUID, string memberName, string memberValue);

        /// <summary>
        /// Gets the value of the instance's member as a serialized string.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <returns>The value of the member as a string.</returns>
        string GetMemberJsonSerializable(string instanceUUID, string memberName);

        /// <summary>
        /// Sets the value of the instance's member by deserializing the JSON string.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <param name="memberValue">The serialized value to set.</param>
        void SetMemberJsonSerializable(string instanceUUID, string memberName, string memberValue);

        /// <summary>
        /// Gets the value of the instance's member as a double.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <returns>The value of the member as a double.</returns>
        double GetMemberNumber(string instanceUUID, string memberName);

        /// <summary>
        /// Sets the value of the instance's member as a double.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <param name="memberValue">The value to set.</param>
        void SetMemberNumber(string instanceUUID, string memberName, double memberValue);

        /// <summary>
        /// Gets the value of the instance's member as a nullable double.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <returns>The value of the member as a nullable double.</returns>
        double? GetMemberNullableNumber(string instanceUUID, string memberName);

        /// <summary>
        /// Sets the value of the instance's member as a nullable double.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <param name="memberValue">The value to set.</param>
        void SetMemberNullableNumber(string instanceUUID, string memberName, double? memberValue);

        /// <summary>
        /// Gets the value of the instance's member as a boolean.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <returns>The value of the member as a boolean.</returns>
        bool GetMemberBoolean(string instanceUUID, string memberName);

        /// <summary>
        /// Sets the value of the instance's member as a boolean.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <param name="memberValue">The value to set.</param>
        void SetMemberBoolean(string instanceUUID, string memberName, bool memberValue);

        /// <summary>
        /// Gets the value of the instance's member as a reference.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <returns>The value of the member as a reference.</returns>
        string GetMemberReference(string instanceUUID, string memberName);

        /// <summary>
        /// Sets the value of the instance's member as a reference.
        /// </summary>
        /// <param name="instanceUUID">The UUID of the instance whose member is being accessed.</param>
        /// <param name="memberName">The name of the member.</param>
        /// <param name="memberUUID">The UUID of the object to set as member.</param>
        void SetMemberReference(string instanceUUID, string memberName, string memberUUID);
    }
}

