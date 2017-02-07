using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNameBeforeLastAlphabetically
{
    public class Program
    {
        static Students[] students = new Students[]
        {
            new Students() { FirstName = "Ivaylo", LastName = "Petrov" },
            new Students() { FirstName = "Pesho", LastName = "Markov" },
            new Students() { FirstName = "Daniel", LastName = "Georgiev" },
            new Students() { FirstName = "Marin", LastName = "Marinov" },
            new Students() { FirstName = "Dancho", LastName = "Ivanov" },
            new Students() { FirstName = "Filip", LastName = "Filipov" },
            new Students() { FirstName = "Daniela", LastName = "Videnova" }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Students whose first name is before their last name alphabetically:");
            GetStudentsFirstNameBeforeLast(students);

            Console.ReadLine();
        }

        public static void GetStudentsFirstNameBeforeLast(Students[] students)
        {
            var firstNameBeforeLast = from a in students
                                      where a.FirstName.CompareTo(a.LastName) < 0
                                      select new { FirstName = a.FirstName, LastName = a.LastName };

            foreach (var item in firstNameBeforeLast)
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}");
                Console.WriteLine();
            }
        }
    }
}
