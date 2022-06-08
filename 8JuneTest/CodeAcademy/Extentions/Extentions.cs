using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAcademy.Extentions
{
    static class Extentions
    {
        public static string ToCapitalize(this string word)
        {
            if (!String.IsNullOrWhiteSpace(word))
            {
                word = word.ToLower();
                word = Char.ToUpper(word[0]) + word.Substring(1);
            }
            return word;
        }

        public static int[] FindHey(this string hey,char word)
        {
            int[] myArr = new int[0];

            for (int i = 0; i < hey.Length; i++)
            {
                if (hey[i]==word)
                {
                    Array.Resize(ref myArr, myArr.Length + 1);
                    myArr[myArr.Length - 1] = i;
                }
            }

            return myArr;
        }
    }
}
