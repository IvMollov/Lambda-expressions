using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSubstring 
{
   public class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string someText = Console.ReadLine();
            StringBuilder text = new StringBuilder(someText);
            try
            {
                StringBuilder newtext = text.SubstringExtensionMethod(2, 5);
                Console.WriteLine(newtext.ToString());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
