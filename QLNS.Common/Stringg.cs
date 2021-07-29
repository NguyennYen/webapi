using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Common
{
    public static class Stringg
    {
        //Count the number of words in a sentence
        public static int Count_word(string cau)
        {
            int sotu = 0;

            cau = cau.Trim() + "";
            for (int i = 0; i < cau.Length - 1; i++)
                if (cau[i] != ' ' && cau[i + 1] == ' ')

                    sotu++;

            return sotu;
        }
        //This method returns a Boolean value that indicates whether the current string instance begins with an uppercase character
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);

        }
    }
}
