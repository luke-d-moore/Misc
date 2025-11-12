using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtensionMethods.LinqExtensionClasses
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Remove Elements from the collection that meet the specified criteria.
        /// </summary>
        /// <returns>An IEnumerable<typeparamref name="T"/> Collection containing only elements which did not meet the removal criteria.</returns>
        public static IEnumerable<T> RemoveWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source is null || !source.Any())
            {
                throw new InvalidOperationException("Cannot compute RemoveWhere for a null or empty set.");
            }

            var enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (!predicate(enumerator.Current))
                {
                    yield return enumerator.Current;
                }
            }
        }
        /// <summary>
        /// Checks if all elements of a Collection exist in another Collection.
        /// </summary>
        /// <param name="itemsToCompare">The Collection containing values to be checked against the source collection.</param>
        /// <returns>A Boolean value, true if all elements of the itemsToCompare collection exist in the source collection, false if any value from itemsToCompare does not exist in the source collection.</returns>
        public static bool Includes<T>(this IEnumerable<T> source, IEnumerable<T> itemsToCompare)
        {
            if (source is null || !source.Any() || itemsToCompare is null)
            {
                throw new InvalidOperationException("Cannot compute Includes for a null or empty set.");
            }
            else if (!itemsToCompare.Any()) return false;

            source = source.ToHashSet();

            var enumerator = itemsToCompare.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (!source.Contains(enumerator.Current)) return false;
            }

            return true;
        }
    }
}
