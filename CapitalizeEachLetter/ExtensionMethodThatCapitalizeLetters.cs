using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeEachLetter
{
   public static class ExtensionMethodThatCapitalizeLetters
    {
        public static string CapitalizeLetters(this String text)
        {
            char[] newText = text.ToCharArray();
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Argument is null or empty");
            }
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Argument is not valid");
            }
            if (newText.Length >= 1)
            {
                if (char.IsLower(newText[0]))
                {
                    newText[0] = char.ToUpper(newText[0]);
                }

            }

            for (int i = 1; i < newText.Length; i++)
            {

                if (newText[i - 1] == ' ')
                {
                    if (char.IsLower(text[i]))
                    {
                        newText[i] = char.ToUpper(newText[i]);
                    }
                }
            }

            return new String(newText);
        }
    }
}
