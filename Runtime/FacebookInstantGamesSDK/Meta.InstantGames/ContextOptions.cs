using Runtime.Linq;

namespace Meta.InstantGames
{
    /// <summary>
    /// An object specifying conditions on the contexts that should be offered.
    /// </summary>
    public partial class ContextOptions : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of ContextOptions
        /// </summary>
        /// <param name="filters">The set of filters to apply to the context suggestions.</param>
        /// <param name="maxSize">The maximum number of participants that a suggested context should ideally have.</param>
        /// <param name="minSize">The minimum number of participants that a suggested context should ideally have.</param>
        public ContextOptions(ContextFilter[] filters = null, double? maxSize = null, double? minSize = null)
        {
            Filters = filters;
            MaxSize = maxSize;
            MinSize = minSize;
        }

        private ContextFilter[] _filters;
        /// <summary>
        /// The set of filters to apply to the context suggestions.
        /// </summary>
        public ContextFilter[] Filters
        {
            get
            {
                var filtersJs = JsNative.JsArray<string>.FromJs(GetMemberReference("filters")).Values;
                return (
                    from e in filtersJs
                    select (ContextFilter) System.Enum.Parse(typeof(ContextFilter), e)
                ).ToArray();
            }
            private set
            {
                _filters = value;
                if (_filters != null)
                {
                    var filtersJs = JsNative.JsArray<string>.FromCs(_filters.Select(e => e.ToString()).ToArray());
                    SetMemberReference("filters", filtersJs);
                }
            }
        }

        /// <summary>
        /// The maximum number of participants that a suggested context should ideally have.
        /// </summary>
        public double? MaxSize
        {
            get => GetMemberNullableNumber("maxSize");
            private set => SetMemberNullableNumber("maxSize", value);
        }

        /// <summary>
        /// The minimum number of participants that a suggested context should ideally have.
        /// </summary>
        public double? MinSize
        {
            get => GetMemberNullableNumber("minSize");
            private set => SetMemberNullableNumber("minSize", value);
        }
    }
}
