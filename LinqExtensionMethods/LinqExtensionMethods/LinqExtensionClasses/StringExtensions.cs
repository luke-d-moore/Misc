using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqExtensionMethods.LinqExtensionClasses
{
    public static class StringExtensions
    {
        /// <summary>
        /// Remove whitespace from the start and end of all elements in the collection, where a specific criteria is met.
        /// </summary>
        /// <returns>An IEnumerable<typeparamref name="T"/> Collection containing elements with no whitespace at the start or end, where the specified criteria was met.</returns>
        public static IEnumerable<string> TrimAll(this IEnumerable<string> source, Func<string, bool> predicate)
        {
            if (source is null || !source.Any())
            {
                throw new InvalidOperationException("Cannot compute TrimAll for a null or empty set.");
            }
            var enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                {
                    yield return enumerator.Current.Trim();
                }
            }
        }
        /// <summary>
        /// Adds a specified string to the end of all elements in the collection, where a specific criteria is met.
        /// </summary>
        /// <returns>An IEnumerable<typeparamref name="T"/> Collection containing elements with the specified value appended to the end of each element, where the specified criteria was met.</returns>
        public static IEnumerable<string> AppendAll(this IEnumerable<string> source, string stringToAppend, Func<string, bool> predicate)
        {
            if (source is null || !source.Any())
            {
                throw new InvalidOperationException("Cannot compute AppendAll for a null or empty set.");
            }

            var enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                {
                    yield return enumerator.Current + stringToAppend;
                }
            }
        }
        /// <summary>
        /// Adds a specified string to the start of all elements in the collection, where a specific criteria is met.
        /// </summary>
        /// <returns>An IEnumerable<typeparamref name="T"/> Collection containing elements with the specified value prepended to the start of each element, where the specified criteria was met.</returns>
        public static IEnumerable<string> PrependAll(this IEnumerable<string> source, string stringToPrepend, Func<string, bool> predicate)
        {
            if (source is null || !source.Any())
            {
                throw new InvalidOperationException("Cannot compute PrependAll for a null or empty set.");
            }

            var enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                {
                    yield return stringToPrepend + enumerator.Current;
                }
            }
        }
        /// <summary>
        /// Converts all elements of the collection to its lowercase form, where a specific criteria is met.
        /// </summary>
        /// <returns>An IEnumerable<typeparamref name="T"/> Collection containing all elements in their lowercase form, where the specified criteria was met.</returns>
        public static IEnumerable<string> LowerAll(this IEnumerable<string> source, Func<string, bool> predicate)
        {
            if (source is null || !source.Any())
            {
                throw new InvalidOperationException("Cannot compute LowerAll for a null or empty set.");
            }

            var enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                {
                    yield return enumerator.Current.ToLower();
                }
            }
        }
        /// <summary>
        /// Converts all elements of the collection to its uppercase form, where a specific criteria is met.
        /// </summary>
        /// <returns>An IEnumerable<typeparamref name="T"/> Collection containing all elements in their uppercase form, where the specified criteria was met.</returns>
        public static IEnumerable<string> UpperAll(this IEnumerable<string> source, Func<string, bool> predicate)
        {
            if (source is null || !source.Any())
            {
                throw new InvalidOperationException("Cannot compute UpperAll for a null or empty set.");
            }

            var enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                {
                    yield return enumerator.Current.ToUpper();
                }
            }
        }
        /// <summary>
        /// Convert the first character of each element of the collection to its uppercase form, where a specific criteria is met.
        /// </summary>
        /// <returns>An IEnumerable<typeparamref name="T"/> Collection containing all elements having the first character in its uppercase form, where the specified criteria was met.</returns>
        public static IEnumerable<string> CapitaliseAll(this IEnumerable<string> source, Func<string, bool> predicate)
        {
            if (source is null || !source.Any())
            {
                throw new InvalidOperationException("Cannot compute CapitaliseAllWhere for a null or empty set.");
            }

            var enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                {
                    yield return enumerator.Current.Capitalise();
                }
                else
                {
                    yield return enumerator.Current;
                }
            }
        }
        /// <summary>
        /// Convert the first character of a string to its uppercase form.
        /// </summary>
        /// <returns>A string which has the first character in its uppercase form.</returns>
        public static string Capitalise(this string source)
        {
            if (source is null)
            {
                throw new InvalidOperationException("Cannot compute Capitalise for a null value.");
            }
            var capitalisedString = string.Empty;
            var chars = source.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == 0)
                {
                    capitalisedString += chars[i].ToString().ToUpper();
                }
                else
                {
                    capitalisedString += chars[i];
                }
            }
            return capitalisedString;
        }
    }
}
