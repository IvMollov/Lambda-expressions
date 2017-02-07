using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lambda
{
    class Program
    {
        public static List<Student> students = new List<Student>()
            {
            new Student() { FirstName = "Ivaylo", LastName = "Petrov",FNumber = "408111", TelephoneNumber = "(02) 412 34 56", EmailAdrress = "ivaylo@abv.bg", Marks = new List<int>() { 4, 6, 3, 5, 5}, GroupNumber = 2, Group = new Group {GroupNumber = 2, DepartmentName = "Mathematics"} },
           new Student() { FirstName = "Pesho", LastName = "Markov", FNumber = "555086", TelephoneNumber = "(02) 655 33 52", EmailAdrress = "pesho@gmail.com", Marks = new List<int>() { 6, 6, 6, 6, 5}, GroupNumber = 1, Group = new Group {GroupNumber = 1, DepartmentName = "Software Technologies"} },
           new Student() { FirstName = "Greta", LastName = "Ivanova", FNumber = "862206", TelephoneNumber = "(082) 322 55 99", EmailAdrress = "greta@mail.bg", Marks = new List<int>() { 6, 3, 3, 2, 5}, GroupNumber = 3, Group = new Group {GroupNumber = 3, DepartmentName = "Biology"} },
           new Student() { FirstName = "Daniela", LastName = "Videnova", FNumber = "555660", TelephoneNumber = "(02) 555 66 77", EmailAdrress = "daniela@abv.bg", Marks = new List<int>() { 5, 6, 5, 6, 5}, GroupNumber = 2, Group = new Group {GroupNumber = 2, DepartmentName = "Mathematics"} },
           new Student() { FirstName = "Gosho", LastName = "Petrov", FNumber = "600600", TelephoneNumber = "(050) 412 34 44", EmailAdrress = "gosho@gmail.com", Marks = new List<int>() { 4, 4, 4, 4, 6}, GroupNumber = 4, Group = new Group {GroupNumber = 4, DepartmentName = "Physics"}  },
           new Student() { FirstName = "Daniel", LastName = "Georgiev", FNumber = "559000", TelephoneNumber = "(066) 555 44 33", EmailAdrress = "daniel@abv.bg", Marks = new List<int>() { 4, 6, 4, 3, 3}, GroupNumber = 2, Group = new Group {GroupNumber = 2, DepartmentName = "Mathematics"} },
           new Student() { FirstName = "Marin", LastName = "Marinov", FNumber = "965406", TelephoneNumber = "(082) 412 34 56", EmailAdrress = "marin@mail.bg", Marks = new List<int>() { 2, 3, 5, 6, 6}, GroupNumber = 1, Group = new Group {GroupNumber = 1, DepartmentName = "Software Technologies"} },
           new Student() { FirstName = "Martin", LastName = "Martion", FNumber = "777890", TelephoneNumber = "(086) 433 5 00", EmailAdrress = "martin@gmail.com", Marks = new List<int>() { 6, 2, 2, 6, 6}, GroupNumber = 3, Group = new Group {GroupNumber = 3, DepartmentName = "Biology"} },
           new Student() { FirstName = "Dancho", LastName = "Ivanov", FNumber = "909006", TelephoneNumber = "(02) 444 32 44", EmailAdrress = "Dancho@abv.bg", Marks = new List<int>() { 2, 5, 2, 5, 5}, GroupNumber = 3, Group = new Group {GroupNumber = 3, DepartmentName = "Biology"}  },
           new Student() { FirstName = "John", LastName = "Smith", FNumber = "323333", TelephoneNumber = "(066) 432 22 44", EmailAdrress = "john@gmail.com", Marks = new List<int>() { 4, 4, 4, 4, 4}, GroupNumber = 1, Group = new Group {GroupNumber = 1, DepartmentName = "Software Technologies"} },
           new Student() { FirstName = "Jack", LastName = "Pitt", FNumber = "896532", TelephoneNumber = "(082) 123 56 78", EmailAdrress = "jack@mail.bg", Marks = new List<int>() { 4, 3, 3, 2, 3}, GroupNumber = 4, Group = new Group {GroupNumber = 4, DepartmentName = "Physics"}  },
           new Student() { FirstName = "Filip", LastName = "Filipov", FNumber = "666060", TelephoneNumber = "(086) 354 55 06", EmailAdrress = "filip@mail.bg", Marks = new List<int>() { 6, 6, 2, 2, 2}, GroupNumber = 2, Group = new Group {GroupNumber = 2, DepartmentName = "Mathematics"} },
            };

        static void Main(string[] args)
        {

            Console.WriteLine("Students from Group Two with LINQ query:");
            GetGroupTwo(students);

            Console.WriteLine("\nStudents from Group Two with extension methods");
            GetGroupTwoExtensionMethod(students);

            Console.WriteLine("\nStudents that have email in abv.bg:");
            GetStudentsInAbv(students);

            Console.WriteLine("\nStudents with phones in Sofia:");
            GetStudentsInSofia(students);

            Console.WriteLine("\nStudents with at least one mark Excellent (6):");
            GetStudentsWithAtLeastOneExcellentMark(students);

            Console.WriteLine("\nStudents with two marks Poor (2):");
            GetStudentsWithTwoPoorMark(students);

            Console.WriteLine("\nStudents enrolled in 2006:");
            GetStudentsEnrolled2006(students);

            Console.WriteLine("\nStudents from \"Mathematics\" department:");
            GetStudentsInMathematicsDepartment(students);

            Console.WriteLine("\nStudents grouped by Department name (using LINQ):");
            GetStudentsGroupedByDepartmentLINQ(students);

            Console.WriteLine("\nStudents grouped by Department name (using Extension methods):");
            GetStudentsGroupedByDepartmentExtensionMethod(students);

            Console.WriteLine("\nStudents sorted by first name and last name in descending order(using Extension methods):");
            GetStudentsOrderedByFirstAndLastNameExtensionMethod(students);

            Console.WriteLine("\nStudents sorted by first name and last name in descending order(using LINQ):");
            GetStudentsOrderedByFirstAndLastNameLINQ(students);

            Console.ReadKey();
        }

        public static void GetGroupTwo(List<Student> students)
        {
            var groupTwoStudents = from p in students
                                   where p.GroupNumber == 2
                                   orderby p.FirstName
                                   select p;

            foreach (var item in groupTwoStudents)
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}, e-mail: {item.EmailAdrress}, " +
                    $"T: {item.TelephoneNumber}, Fax: {item.FNumber}, Marks: ");
                foreach (var mark in item.Marks)
                {
                    Console.Write("{0} ", mark);
                }
                Console.WriteLine();
            }
        }

        public static void GetGroupTwoExtensionMethod(List<Student> students)
        {
            var group2Students = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName);

            foreach (var item in group2Students)
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}, e-mail: {item.EmailAdrress}, " +
                    $"T: {item.TelephoneNumber}, Fax: {item.FNumber}, Marks: ");
                foreach (var mark in item.Marks)
                {
                    Console.Write("{0} ", mark);
                }
                Console.WriteLine();
            }
        }

        public static void GetStudentsInAbv(List<Student> students)
        {
            string abv = "abv.bg";
            var abvStudents = from a in students
                              where a.EmailAdrress.Contains(abv)
                              select a;

            foreach (var item in abvStudents)
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}, e-mail: {item.EmailAdrress}, " +
                    $"T: {item.TelephoneNumber}, Fax: {item.FNumber}, Marks: ");
                foreach (var mark in item.Marks)
                {
                    Console.Write("{0} ", mark);
                }
                Console.WriteLine();
            }
        }

        public static void GetStudentsInSofia(List<Student> students)
        {
            Regex areaCode = new Regex(@"^\(?02\)?");
            var studentsOfSofia = from s in students
                                  where areaCode.IsMatch(s.TelephoneNumber)
                                  select s;

            foreach (var item in studentsOfSofia)
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}, e-mail: {item.EmailAdrress}, " +
                    $"T: {item.TelephoneNumber}, Fax: {item.FNumber}, Marks: ");
                foreach (var mark in item.Marks)
                {
                    Console.Write("{0} ", mark);
                }
                Console.WriteLine();
            }
        }

        public static void GetStudentsWithAtLeastOneExcellentMark(List<Student> students)
        {
            var atLeastOneExellent = from s in students
                                     from m in s.Marks
                                     where m == 6
                                     select new { FullName = s.FirstName + " " + s.LastName, Email = s.EmailAdrress };
            var list = atLeastOneExellent.Distinct().ToList();

            foreach (var item in list)
            {
                Console.Write($"Full name: {item.FullName}, e-mail: {item.Email}");
                Console.WriteLine();
            }
        }

        public static void GetStudentsWithTwoPoorMark(List<Student> students)
        {
            var poors = from st in students
                        where st.Marks.Count(x => x == 2) == 2
                        select new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks };

            foreach (var item in poors)
            {
                Console.Write("Full name: {0}, marks: ", item.FullName);
                foreach (var marks in item.Marks)
                {
                    Console.Write("{0}, ", marks);
                }
                Console.WriteLine();
            }
        }

        public static void GetStudentsEnrolled2006(List<Student> students)
        {
            var enrolled = from st in students
                           where st.FNumber[4] == '0' && st.FNumber[5] == '6'
                           select new { FullName = st.FirstName + " " + st.LastName, Fnumber = st.FNumber };

            foreach (var item in enrolled)
            {
                Console.Write("Full name: {0}, FNumber: {1}", item.FullName, item.Fnumber);

                Console.WriteLine();
            }
        }

        public static void GetStudentsInMathematicsDepartment(List<Student> students)
        {
            var mathematicsSt = from st in students
                                where st.Group.DepartmentName == "Mathematics"
                                select new
                                {
                                    FullName = st.FirstName + " " + st.LastName,
                                    GroupNumber = st.Group.GroupNumber,
                                    Department = st.Group.DepartmentName
                                };

            foreach (var item in mathematicsSt)
            {
                Console.Write("Full name: {0}, Group number: {1}, Department: {2}", item.FullName, item.GroupNumber, item.Department);

                Console.WriteLine();
            }
        }

        public static void GetStudentsGroupedByDepartmentLINQ(List<Student> students)
        {
            var groupedByDepartment = from st in students
                                      group st by st.Group.DepartmentName into g
                                      select new { FullName = g.ToList(), Department = g.Key };

            foreach (var item in groupedByDepartment)
            {
                Console.Write("Department: {0},  Full name: ", item.Department);
                foreach (var names in item.FullName)
                {
                    Console.Write("{0} {1}, ", names.FirstName, names.LastName);
                }
                Console.WriteLine();
            }
        }

        public static void GetStudentsGroupedByDepartmentExtensionMethod(List<Student> students)
        {
            var groupedByDepartment2 = students.GroupBy(x => x.Group.DepartmentName).
                Select(y => new { FullName = y.ToList(), Department = y.Key });

            foreach (var item in groupedByDepartment2)
            {
                Console.Write("Department: {0},  Full name: ", item.Department);
                foreach (var names in item.FullName)
                {
                    Console.Write("{0} {1}, ", names.FirstName, names.LastName);
                }
                Console.WriteLine();
            }
        }

        public static void GetStudentsOrderedByFirstAndLastNameExtensionMethod(List<Student> students)
        {
            var orderedByFirstAndLastName = students.OrderByDescending(x => x.FirstName).
                ThenByDescending(a => a.LastName).Select(y => new
                {
                    FullName = y.FirstName + " " + y.LastName,
                    FNumber = y.FNumber,
                    PhoneNumber = y.TelephoneNumber,
                    Email = y.EmailAdrress
                });

            foreach (var item in orderedByFirstAndLastName)
            {
                Console.Write("Full name: {0}, FNumber: {1}, Phone number: {2}, e-mail address: {3}",
                    item.FullName, item.FNumber, item.PhoneNumber, item.Email);
                Console.WriteLine();
            }
        }

        public static void GetStudentsOrderedByFirstAndLastNameLINQ(List<Student> students)
        {
            var orderedByFirstAndLastName = from student in students
                                            orderby student.LastName descending
                                            orderby student.FirstName descending
                                            select new
                                            {
                                                FullName = student.FirstName + " " + student.LastName,
                                                FNumber = student.FNumber,
                                                PhoneNumber = student.TelephoneNumber,
                                                Email = student.EmailAdrress
                                            };

            foreach (var item in orderedByFirstAndLastName)
            {
                Console.Write("Full name: {0}, FNumber: {1}, Phone number: {2}, e-mail address: {3}",
                    item.FullName, item.FNumber, item.PhoneNumber, item.Email);
                Console.WriteLine();
            }
        }
    }
}
