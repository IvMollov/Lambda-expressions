using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtgensionMethods
{
   public static class ExtensionMethodSum
    {
        public static int Sum(this IEnumerable<int> source)
        {
            int sum = 0;

            foreach (var item in source)
            {
                sum += item;
            }

            return sum;
        }
    }
}
