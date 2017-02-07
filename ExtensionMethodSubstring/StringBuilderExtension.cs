using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSubstring
{
    public static class StringBuilderExtension
    {
        public static StringBuilder SubstringExtensionMethod(this StringBuilder a, int index, int length)
        {
            if ((index + length) > a.Length)
            {
                throw new ArgumentOutOfRangeException("Index out of range!");
            }
            StringBuilder text = new StringBuilder();

            for (int i = index; i < length + index; i++)
            {
                text.Append(a[i]);
            }

            return text;
        }
    }
}
