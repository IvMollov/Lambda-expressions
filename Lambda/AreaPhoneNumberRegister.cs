using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LINQ
{
    public class AreaPhoneNumberRegister
    {
       private static Regex areaCode;

        public static Regex CodeSofia()
        {
           return areaCode = new Regex(@"^\(?02\)?");
        }

        public static Regex CodePlovdiv()
        {
            return areaCode = new Regex(@"^\(?032\)?");
        }

        public static Regex CodeYambol()
        {
            return areaCode = new Regex(@"^\(?046\)?");
        }

        public static Regex CodeSilistra()
        {
            return areaCode = new Regex(@"^\(?086\)?");
        }

        public static Regex CodeBurgas()
        {
            return areaCode = new Regex(@"^\(?056\)?");
        }

        public static Regex CodeGabrovo()
        {
            return areaCode = new Regex(@"^\(?066\)?");
        }

        public static Regex CodeVelikoTarnovo()
        {
            return areaCode = new Regex(@"^\(?062\)?");
        }
    }
}
