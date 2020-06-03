using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    public class evenNum
    {

        public static int evenSum(List<int> args)
        {
            int eSum = 0;
            foreach (int i in args)
            {
                if( i % 2 == 0) { eSum += i;}
            }

            return eSum;
        }

        public static void charOut(List<string> args, int letter)
        {
            foreach (string i in args)
            {
                if (i.Length == letter) { Console.WriteLine(i); }
            }

            return;
        }

    }
}
