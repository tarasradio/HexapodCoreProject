using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrundGeneratorProject.Core
{
    public static class StringOperation
    {
        public static int SkipWhiteSpaces(string str, int pos)
        {
            while (char.IsWhiteSpace(str[pos]) && (pos + 1 < str.Length)) { pos++; }
            return pos;
        }

        public static int ReadValue(string str, ref string output, int pos)
        {
            output = "";
            while (!char.IsWhiteSpace(str[pos]) && (pos + 1 < str.Length))
            { output += str[pos]; pos++; }
            return pos;
        }
    }
}
