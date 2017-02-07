using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
   public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FNumber { get; set; }

        public string TelephoneNumber { get; set; }      

        public string EmailAdrress { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }
    }
}
