using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersDivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter ({0}) number: ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numbers divisible by 3 and 7 using Extension methods:");
            DivisibleByThreeAndSevenExtensionMethod(numbers);

            Console.WriteLine("\nNumbers divisible by 3 and 7 using LINQ query:");
            DivisibleByThreeAndSevenLINQ(numbers);

            Console.ReadLine();
        }

        public static void DivisibleByThreeAndSevenExtensionMethod(int[] array)
        {
            var divisibleBy7And3 = array.Where(x => x % 7 == 0 && x % 3 == 0);

            foreach (var item in divisibleBy7And3)
            {
                Console.Write("{0}, ", item);
            }
        }

        public static void DivisibleByThreeAndSevenLINQ(int[] array)
        {
            var divisibleBy7And3 = from s in array
                                   where s % 7 == 0 && s % 3 == 0
                                   select s;

            foreach (var item in divisibleBy7And3)
            {
                Console.Write("{0}, ", item);
            }
        }
    }
}
