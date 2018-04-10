using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Popivnenko._11.BinarySearch
{
    /// <summary>
    /// Implements basic binary search within generic array.
    /// </summary>
    public static class Searcher
    {
        /// <summary>
        /// The not found constant
        /// </summary>
        public static readonly int NotFound = -1;

        /// <summary>
        /// Implements the binary search algorithm.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">The array.</param>
        /// <param name="element">The element.</param>
        /// <param name="comparison">The comparison.</param>
        /// <returns>
        /// Returns found element's index
        /// or
        /// <see cref="NotFound"/>
        /// </returns>
        public static int BinarySearch<T>(this T[] items, T element, Comparison<T> comparison)
        {
            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            int left = 0, right = items.Length - 1;
            int mid = right / 2;

            while (left <= right)
            {
                int result = comparison(items[mid], element);
                if (result == 0)
                {
                    return mid;
                }
                else if (result < 0)
                {
                    left = mid + 1;
                    mid = (left + right) / 2;
                }
                else if (true)
                {
                    right = mid - 1;
                    mid = (left + right) / 2;
                }
            }

            return NotFound;
        }

        /// <summary>
        /// Implements the binary search algorithm.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">The items.</param>
        /// <param name="element">The element.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns>
        /// Returns found element's index
        /// or
        /// <see cref="NotFound"/>
        /// </returns>
        public static int BinarySearch<T>(this T[] items, T element, IComparer<T> comparer)
        {
            return BinarySearch<T>(items, element, comparer.Compare);
        }

        /// <summary>
        /// Binaries the search.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items">The items.</param>
        /// <param name="element">The element.</param>
        /// <returns>
        /// Returns found element's index
        /// or
        /// <see cref="NotFound"/>
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Specified type doesn't implement IComparable interface
        /// </exception>
        public static int BinarySearch<T>(this T[] items, T element)
        {
            if (element is IComparable)
            {
                IComparer<T> comparer = Comparer<T>.Default;
                return BinarySearch<T>(items, element, comparer.Compare);
            }
            else
            {
                throw new InvalidOperationException("Specified type doesn't implement IComparable<" + element.GetType() + "> interface");
            }
        }
    }
}
