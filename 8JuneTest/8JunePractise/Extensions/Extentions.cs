using System;
using System.Collections.Generic;
using System.Text;

namespace _8JunePractise.Extensions
{
    static class Extentions
    {
        public static int[] FindIndexes(this string word,char character)
        {
            int[] myArr = new int[0];



            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==character)
                {
                    Array.Resize(ref myArr, myArr.Length + 1);
                    myArr[myArr.Length - 1] = i;
                }
            }
            if (myArr.Length==0)
            {
                Array.Resize(ref myArr, myArr.Length + 1);
                myArr[myArr.Length - 1] = -1;
            }
            return myArr;
        }


        public static int FindPower(this int num1,int power)
        {
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result = result * num1;
            }
            return result;
        }
    }
}
