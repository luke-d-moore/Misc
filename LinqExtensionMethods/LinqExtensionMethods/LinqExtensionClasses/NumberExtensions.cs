using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtensionMethods.LinqExtensionClasses
{
    public static class NumberExtensions
    {
        /// <summary>
        /// Calculates the source as a percentage of the total value specified
        /// </summary>
        /// <returns>A double representing the value of source as a percentage of the total value specified.</returns>
        public static double Percentage(this double source, double total)
        {
            if (total == 0) throw new InvalidOperationException("total cannot be 0");
            return (source / total) * 100;
        }
        /// <summary>
        /// Calculates the source as a percentage of the total value specified
        /// </summary>
        /// <returns>A decimal representing the value of source as a percentage of the total value specified.</returns>
        public static decimal Percentage(this decimal source, decimal total)
        {
            if (total == 0) throw new InvalidOperationException("total cannot be 0");
            return (source / total) * 100;
        }
    }
}
