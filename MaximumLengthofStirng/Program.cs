using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumLengthofStirng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());
            string[] strings = new string[size];

            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write("Enter ({0}) string:", i);
                strings[i] = Console.ReadLine();
            }
            var length = strings.Max(x => x.Length);
            var maxLength = strings.FirstOrDefault(x => x.Length == length);

            Console.WriteLine("String with maximum length is {0}", maxLength.ToString());
            Console.ReadKey();
        }
    }
}
