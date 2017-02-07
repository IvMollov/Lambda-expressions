using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtgensionMethods
{
   public static class ExtensionMethodProduct
    {
        public static int Product(this IEnumerable<int> source)
        {
            int product = 1;

            foreach (var item in source)
            {
                product *= item;
            }

            return product;
        }
    }
}
