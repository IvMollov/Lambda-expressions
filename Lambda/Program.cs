using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LINQ
{
    class Program
    {
        public static List<Student> students = new List<Student>()
            {
            new Student() { FirstName = "Ivaylo", LastName = "Petrov",FNumber = "408111", TelephoneNumber = "(02) 412 34 56", EmailAdrress = "ivaylo@abv.bg", Marks = new List<int>() { 4, 6, 3, 5, 5}, GroupNumber = 2, Group = new Group {GroupNumber = 2, DepartmentName = "Mathematics"} },
           new Student() { FirstName = "Pesho", LastName = "Markov", FNumber = "555086", TelephoneNumber = "(02) 655 33 52", EmailAdrress = "pesho@gmail.com", Marks = new List<int>() { 6, 6, 6, 6, 5}, GroupNumber = 1, Group = new Group {GroupNumber = 1, DepartmentName = "Software Technologies"} },
           new Student() { FirstName = "Greta", LastName = "Ivanova", FNumber = "862206", TelephoneNumber = "(064) 322 55 99", EmailAdrress = "greta@mail.bg", Marks = new List<int>() { 6, 3, 3, 2, 5}, GroupNumber = 3, Group = new Group {GroupNumber = 3, DepartmentName = "Biology"} },
           new Student() { FirstName = "Daniela", LastName = "Videnova", FNumber = "555660", TelephoneNumber = "(02) 555 66 77", EmailAdrress = "daniela@abv.bg", Marks = new List<int>() { 5, 6, 5, 6, 5}, GroupNumber = 2, Group = new Group {GroupNumber = 2, DepartmentName = "Mathematics"} },
           new Student() { FirstName = "Gosho", LastName = "Petrov", FNumber = "600600", TelephoneNumber = "(056) 412 34 02", EmailAdrress = "gosho@gmail.com", Marks = new List<int>() { 4, 4, 4, 4, 6}, GroupNumber = 4, Group = new Group {GroupNumber = 4, DepartmentName = "Physics"}  },
           new Student() { FirstName = "Daniel", LastName = "Georgiev", FNumber = "559000", TelephoneNumber = "(066) 555 44 33", EmailAdrress = "daniel@abv.bg", Marks = new List<int>() { 4, 6, 4, 3, 3}, GroupNumber = 2, Group = new Group {GroupNumber = 2, DepartmentName = "Mathematics"} },
           new Student() { FirstName = "Marin", LastName = "Marinov", FNumber = "965406", TelephoneNumber = "(032) 412 34 56", EmailAdrress = "marin@mail.bg", Marks = new List<int>() { 2, 3, 5, 6, 6}, GroupNumber = 1, Group = new Group {GroupNumber = 1, DepartmentName = "Software Technologies"} },
           new Student() { FirstName = "Martin", LastName = "Martion", FNumber = "777890", TelephoneNumber = "(086) 433 5 00", EmailAdrress = "martin@gmail.com", Marks = new List<int>() { 6, 2, 2, 6, 6}, GroupNumber = 3, Group = new Group {GroupNumber = 3, DepartmentName = "Biology"} },
           new Student() { FirstName = "Dancho", LastName = "Ivanov", FNumber = "909006", TelephoneNumber = "(02) 444 32 44", EmailAdrress = "Dancho@abv.bg", Marks = new List<int>() { 2, 5, 2, 5, 5}, GroupNumber = 3, Group = new Group {GroupNumber = 3, DepartmentName = "Biology"}  },
           new Student() { FirstName = "John", LastName = "Smith", FNumber = "323333", TelephoneNumber = "(046) 432 22 44", EmailAdrress = "john@gmail.com", Marks = new List<int>() { 4, 4, 4, 4, 4}, GroupNumber = 1, Group = new Group {GroupNumber = 1, DepartmentName = "Software Technologies"} },
           new Student() { FirstName = "Jack", LastName = "Pitt", FNumber = "896532", TelephoneNumber = "(056) 123 56 78", EmailAdrress = "jack@mail.bg", Marks = new List<int>() { 4, 3, 3, 2, 3}, GroupNumber = 4, Group = new Group {GroupNumber = 4, DepartmentName = "Physics"}  },
           new Student() { FirstName = "Filip", LastName = "Filipov", FNumber = "666060", TelephoneNumber = "(086) 354 55 06", EmailAdrress = "filip@mail.bg", Marks = new List<int>() { 6, 6, 2, 2, 2}, GroupNumber = 2, Group = new Group {GroupNumber = 2, DepartmentName = "Mathematics"} },
            };
        static void Main(string[] args)
        {

            Console.WriteLine("Students from Group Two with LINQ query:");
            Print.GetGroupTwo(students);

            Console.WriteLine("\nStudents from Group Two with extension methods");
            Print.GetGroupTwoExtensionMethod(students);

            Console.WriteLine("\nStudents that have email in abv.bg:");
            Print.GetStudentsInAbv(students);

            Console.WriteLine("\nStudents with phones in Sofia:");
            Print.GetStudentsInSofia(students);

            Console.WriteLine("\nStudents with at least one mark Excellent (6):");
            Print.GetStudentsWithAtLeastOneExcellentMark(students);

            Console.WriteLine("\nStudents with two marks Poor (2):");
            Print.GetStudentsWithTwoPoorMark(students);

            Console.WriteLine("\nStudents enrolled in 2006:");
            Print.GetStudentsEnrolled2006(students);

            Console.WriteLine("\nStudents from \"Mathematics\" department:");
            Print.GetStudentsInMathematicsDepartment(students);

            Console.WriteLine("\nStudents grouped by Department name (using LINQ):");
            Print.GetStudentsGroupedByDepartmentLINQ(students);

            Console.WriteLine("\nStudents grouped by Department name (using Extension methods):");
            Print.GetStudentsGroupedByDepartmentExtensionMethod(students);

            Console.WriteLine("\nStudents sorted by first name and last name in descending order(using Extension methods):");
            Print.GetStudentsOrderedByFirstAndLastNameExtensionMethod(students);

            Console.WriteLine("\nStudents sorted by first name and last name in descending order(using LINQ):");
            Print.GetStudentsOrderedByFirstAndLastNameLINQ(students);

            Console.ReadKey();
        }
    }
}
