using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtgensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(){1, 3, 5, 3, 2};

            int sum = list.Sum();
            Console.WriteLine("Sum is: {0}", sum);

            int product = list.Product();
            Console.WriteLine("Product is: {0}", product);

            int min = list.Min();
            Console.WriteLine("Minimal value is: {0}", min);

            int max = list.Max();
            Console.WriteLine("Maximal value is: {0}", max);

            double average = list.Average();
            Console.WriteLine("Average is: {0}", average);
        }
    }
}
