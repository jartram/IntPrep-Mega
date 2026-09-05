/*
 =======================================================================================
 CHALLENGE: NumberManipulator (09-loops)
 CHAPTER: Chapter09_Loops
 
 DESCRIPTION:
 * # Number Manipulator
 *
 * Number Manipulator is a small app that allows us to manipulate numbers on a digit level.
 *
 * The app provides the following methods in the class `Manipulator`:
 *
 * * `Reverse(int value)`: reverses numbers, eg converting `12345` to `54321`. You simply reverse the number. When a number ends in `0`(s), you may ignore them for the result.
 * * `Complement(int value)`: calculate he complement of numbers, eg convert `12345` to `87654`. The value is per digit subtracted from `9`.
 * * `DigitSum(int value)`: determine the sum of the individual digits. The digit sum of `12345` is `15.
 *
 * All methodes can be realized by approaching the number digit by digit. In other words, by working with division by `10` and module `10`.
 *
 * The `Main()` method already contains a small demo application. Feel free to change it to your liking.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Number Manipulator
 *
 * Let's reverse some numbers:
 *  The inverted value of 123 is 321
 *  The inverted value of 9200 is 29
 *  The inverted value of 111 is 111
 *  The inverted value of 0 is 0
 *
 * Let's complement some numbers:
 *  The complement value of 123 is 876
 *  The complement value of 9200 is 799
 *  The complement value of 111 is 888
 *  The complement value of 8 is 1
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter09_Loops.NumberManipulator.UnitTestManipulator
 =======================================================================================
*/

using System;
using System.Linq;

namespace CSharpPractical.Chapter09_Loops.NumberManipulator
{
    public class Manipulator
    {
        public static int Reverse(int number)
        {
            if (number == 0) return 0;
            int rev = 0;
            int n = number;
            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n /= 10;
            }
            return rev;
        }

        public static int Complement(int number)
        {
            if (number == 0) return 9;
            string s = number.ToString();
            string res = "";
            foreach (char c in s)
            {
                res += (9 - (c - '0')).ToString();
            }
            return int.Parse(res);
        }

        public static int DigitSum(int number)
        {
            return number.ToString().Sum(c => c - '0');
        }
    }
}
