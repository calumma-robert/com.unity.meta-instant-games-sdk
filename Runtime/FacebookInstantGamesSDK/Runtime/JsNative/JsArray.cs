using System;

namespace JsNative
{
    internal class JsArray<T> : JsNative
    {
        public T[] Values
        {
            get => ValuesFromJs();

            private set => ValuesToJs(value);
        }

        private JsArray(string uuid, IJsNativeLib jsNativeLib = null) : base(uuid, jsNativeLib) { }

        private JsArray(T[] values, IJsNativeLib jsNativeLib = null) : base(null, jsNativeLib)
        {
            Values = values;
        }

        public static JsArray<T> FromJs(string uuid, IJsNativeLib jsNativeLib = null)
        {
            return new JsArray<T>(uuid, jsNativeLib);
        }

        public static JsArray<T> FromCs(T[] values, IJsNativeLib jsNativeLib = null)
        {
            return new JsArray<T>(values, jsNativeLib);
        }

        private void ValuesToJs(T[] values)
        {
            var length = values.Length;
            switch (values)
            {
                case bool[] boolValues:
                    for (int i = 0; i < length; i++)
                        SetMemberBoolean(i.ToString(), boolValues[i]);
                    break;

                case double[] doubleValues:
                    for (int i = 0; i < length; i++)
                        SetMemberNumber(i.ToString(), doubleValues[i]);
                    break;

                case double?[] nullableDoubleValues:
                    for (int i = 0; i < length; i++)
                        SetMemberNullableNumber(i.ToString(), nullableDoubleValues[i]);
                    break;

                case string[] stringValues:
                    for (int i = 0; i < length; i++)
                        SetMemberString(i.ToString(), stringValues[i]);
                    break;

                default:
                    throw new NotImplementedException($"Element type {typeof(T)} is not implemented for JsArray.");
            }
        }

        private T[] ValuesFromJs()
        {
            var length = (int) GetMemberNumber("length");
            var values = new T[length];

            switch (values)
            {
                case bool[] boolValues:
                    for (int i = 0; i < length; i++)
                        boolValues[i] = GetMemberBoolean(i.ToString());
                    break;

                case double[] doubleValues:
                    for (int i = 0; i < length; i++)
                        doubleValues[i] = GetMemberNumber(i.ToString());
                    break;

                case double?[] nullableDoubleValues:
                    for (int i = 0; i < length; i++)
                        nullableDoubleValues[i] = GetMemberNullableNumber(i.ToString());
                    break;

                case string[] stringValues:
                    for (int i = 0; i < length; i++)
                        stringValues[i] = GetMemberString(i.ToString());
                    break;

                default:
                    throw new NotImplementedException($"Element type {typeof(T)} is not implemented for JsArray.");
            }

            return values;
        }

        protected override string CreateJs() => CreateArray();
    }
}
