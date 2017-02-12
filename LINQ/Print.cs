using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LINQ
{
    public class Print
    {

        public static void GetGroupTwo(List<Student> students)
        {
            var groupTwoStudents = from p in students
                                   where p.GroupNumber == 2
                                   orderby p.FirstName
                                   select p;

            groupTwoStudents.ToList().ForEach(item =>
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}, e-mail: {item.EmailAdrress}, " +
                        $"T: {item.TelephoneNumber}, Fax: {item.FNumber}, Marks: ");
                item.Marks.ToList().ForEach(mark => Console.Write($"{mark} "));
                Console.WriteLine();
            });
        }

        public static void GetGroupTwoExtensionMethod(List<Student> students)
        {
            var group2Students = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName).ToList();

            group2Students.ForEach(item =>
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}, e-mail: {item.EmailAdrress}, " +
                        $"T: {item.TelephoneNumber}, Fax: {item.FNumber}, Marks: ");
                item.Marks.ToList().ForEach(mark => Console.Write($"{mark} "));
                Console.WriteLine();
            });
        }

        public static void GetStudentsInAbv(List<Student> students)
        {
            string abv = "abv.bg";
            var abvStudents = students.Where(x => x.EmailAdrress.Contains(abv)).ToList();

            abvStudents.ForEach(item =>
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}, e-mail: {item.EmailAdrress}, " +
                        $"T: {item.TelephoneNumber}, Fax: {item.FNumber}, Marks: ");
                item.Marks.ToList().ForEach(mark => Console.Write($"{mark} "));
                Console.WriteLine();
            });
        }

        public static void GetStudentsInSofia(List<Student> students)
        {

            var studentsOfSofia = students.Where(x => AreaPhoneNumberRegister.CodeSofia().IsMatch(x.TelephoneNumber)).ToList();

            studentsOfSofia.ForEach(item =>
            {
                Console.Write($"First name: {item.FirstName}, Last name: {item.LastName}, e-mail: {item.EmailAdrress}, " +
                        $"T: {item.TelephoneNumber}, Fax: {item.FNumber}, Marks: ");
                item.Marks.ToList().ForEach(mark => Console.Write($"{mark} "));
                Console.WriteLine();
            });
        }

        public static void GetStudentsWithAtLeastOneExcellentMark(List<Student> students)
        {
            var atLeastOneExellent = from s in students
                                     from m in s.Marks
                                     where m == 6
                                     select new { FullName = s.FirstName + " " + s.LastName, Email = s.EmailAdrress };
            var list = atLeastOneExellent.Distinct().ToList();

            list.ForEach(x =>
            {
                Console.Write($"Full name: {x.FullName}, e-mail: {x.Email}");
                Console.WriteLine();
            });
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

            enrolled.ToList().ForEach(x =>
            {
                Console.Write("Full name: {0}, FNumber: {1}", x.FullName, x.Fnumber);
                Console.WriteLine();
            });

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

            groupedByDepartment.ToList().ForEach(x =>
            {
                Console.Write("Department: {0},  Full name: ", x.Department);
                x.FullName.ForEach(a => Console.Write("{0} {1}, ", a.FirstName, a.LastName));
                Console.WriteLine();
            });
        }

        public static void GetStudentsGroupedByDepartmentExtensionMethod(List<Student> students)
        {
            var groupedByDepartment2 = students.GroupBy(x => x.Group.DepartmentName).
                Select(y => new { FullName = y.ToList(), Department = y.Key }).ToList();

            groupedByDepartment2.ForEach(x =>
            {
                Console.Write("Department: {0},  Full name: ", x.Department);
                x.FullName.ForEach(a => Console.Write("{0} {1}, ", a.FirstName, a.LastName));
                Console.WriteLine();
            });
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

            orderedByFirstAndLastName.ToList().ForEach(x =>
            {
                Console.Write("Full name: {0}, FNumber: {1}, Phone number: {2}, e-mail address: {3}",
                    x.FullName, x.FNumber, x.PhoneNumber, x.Email);
                Console.WriteLine();
            });
        }
    }
}
