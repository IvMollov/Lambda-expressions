using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtgensionMethods
{
   public static class ExtensionMethodMin
    {
        public static int Min(this IEnumerable<int> source)
        {
            int min = int.MaxValue;
            int tempMin = int.MaxValue;

            foreach (var item in source)
            {
                tempMin = item;
                if(tempMin < min)
                {
                    min = tempMin;
                }
            }

            return min;
        }
    }
}
