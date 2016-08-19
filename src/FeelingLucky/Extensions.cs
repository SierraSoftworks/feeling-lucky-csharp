using System.Collections.Generic;

namespace FeelingLucky
{
    public static class FeelingLuckyExtensions
    {
        public static object Lucky<T>(this T target) {
            var lucky = new FeelingLucky(typeof(T), new SuppressBoringMethodFilter());
            return lucky.Execute(target);
        }

        public static S Lucky<T, S>(this T target) {
            var lucky = new FeelingLucky(typeof(T), new SuppressBoringMethodFilter(), new ReturnTypeMethodFilter(typeof(S)));
            return (S)lucky.Execute(target);
        }
    }

    static class EnumerableExtensions
    {
        public static IEnumerable<T> Append<T>(this IEnumerable<T> collection, params T[] items)
        {
            foreach (var item in collection)
                yield return item;

            foreach (var item in items)
                yield return item;
        }

        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> collection, params T[] items)
        {
            foreach (var item in items)
                yield return item;

            foreach (var item in collection)
                yield return item;
        }
    }
}
