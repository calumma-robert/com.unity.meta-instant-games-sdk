namespace JsNative
{
    internal class JsRefArray<T> : JsNative
        where T : JsNative, new()
    {
        public T[] Values
        {
            get => ValuesFromJs();

            private set => ValuesToJs(value);
        }

        private JsRefArray(string uuid, IJsNativeLib jsNativeLib = null) : base(uuid, jsNativeLib) { }

        private JsRefArray(T[] values, IJsNativeLib jsNativeLib = null) : base(null, jsNativeLib)
        {
            Values = values;
        }

        public static JsRefArray<T> FromJs(string uuid, IJsNativeLib jsNativeLib = null)
        {
            return new JsRefArray<T>(uuid, jsNativeLib);
        }

        public static JsRefArray<T> FromCs(T[] values, IJsNativeLib jsNativeLib = null)
        {
            return new JsRefArray<T>(values, jsNativeLib);
        }

        private void ValuesToJs(T[] values)
        {
            for (int i = 0; i < values.Length; ++i)
            {
                var value = values[i];
                SetMemberReference(i.ToString(), value);
            }
        }

        private T[] ValuesFromJs()
        {
            var length = (int) GetMemberNumber("length");
            var values = new T[length];

            for (int i = 0; i < length; ++i)
            {
                var value = new T
                {
                    _jsNativeLib = _jsNativeLib,
                    Uuid = _jsNativeLib.GetMemberReference(this.Uuid, i.ToString())
                };

                values[i] = value;
            }

            return values;
        }

        internal override string CreateJs() => CreateArray();
    }
}
