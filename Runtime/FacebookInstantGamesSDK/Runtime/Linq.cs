using System;
using System.Collections.Generic;

namespace Runtime.Linq
{
    /// <summary>
    /// Extension methods for IEnumerable{T}, mimicking Linq to Objects from System.Linq.
    /// This is included so we can use Linq operators in Unity, where the use of System.Linq is forbidden.
    /// </summary>
    internal static class Linq
    {
        public static IEnumerable<TResult> Select<T, TResult>(this IEnumerable<T> values, Func<T, TResult> iteratee)
        {
            foreach (var value in values)
            {
                yield return iteratee(value);
            }
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> values, Predicate<T> predicate)
        {
            foreach (var value in values)
            {
                if (predicate(value))
                {
                    yield return value;
                }
            }
        }

        public static List<T> ToList<T>(this IEnumerable<T> values) => new List<T>(values);

        public static T[] ToArray<T>(this IEnumerable<T> values)
        {
            var list = values.ToList();
            var result = new T[list.Count];

            for (var i = 0; i < result.Length; ++i)
            {
                result[i] = list[i];
            }

            return result;
        }
    }
}
