using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtgensionMethods
{
   public static class ExtensionMethodMax
    {
        public static int Max(this IEnumerable<int> source)
        {
            int max = int.MinValue;
            int tempMax = int.MinValue;

            foreach (var item in source)
            {
                tempMax = item;
                if (tempMax > max)
                {
                    max = tempMax;
                }
            }

            return max;
        }
    }
}
