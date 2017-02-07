using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsBetweenAge18_24
{
    class Program
    {
        static Students[] students = new Students[]
        {
            new Students() { FirstName = "Ivaylo", LastName = "Petrov", Age = 23 },
            new Students() { FirstName = "Pesho", LastName = "Markov", Age = 18 },
            new Students() { FirstName = "Daniel", LastName = "Georgiev", Age = 25 },
            new Students() { FirstName = "Marin", LastName = "Marinov", Age = 29 },
            new Students() { FirstName = "Dancho", LastName = "Ivanov", Age = 32 },
            new Students() { FirstName = "Filip", LastName = "Filipov", Age = 22 },
            new Students() { FirstName = "Daniela", LastName = "Videnova", Age = 21 }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Students with age between 18 - 24 years:");
            GetStudentsBetween18And24Years(students);

            Console.ReadLine();
        }

        public static void GetStudentsBetween18And24Years(Students[] students)
        {
            var between18and24 = from a in students
                                      where a.Age >= 18 && a.Age <= 24
                                      select new { FirstName = a.FirstName, LastName = a.LastName };

            foreach (var item in between18and24)
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}");
                Console.WriteLine();
            }
        }
    }
}
