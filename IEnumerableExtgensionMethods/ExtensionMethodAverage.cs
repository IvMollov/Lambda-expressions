using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtgensionMethods
{
   public static class ExtensionMethodAverage
    {
        public static double Average(this IEnumerable<int> source)
        {
            double average = 0;
            int sum = 0;
            foreach (var item in source)
            {
                sum += item;
            }

            average = (double)sum / source.Count();
            return average;
        }
    }
}
