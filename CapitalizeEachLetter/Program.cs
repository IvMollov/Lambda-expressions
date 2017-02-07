using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeEachLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            try
            {
                string newText = text.CapitalizeLetters();
                Console.WriteLine(newText);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
