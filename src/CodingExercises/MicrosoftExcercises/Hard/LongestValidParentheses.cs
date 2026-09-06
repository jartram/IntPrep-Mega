/*
 =======================================================================================
 CHALLENGE: LongestValidParentheses
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestValidParentheses problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LongestValidParenthesesTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class LongestValidParentheses
    {
        public int LongestValidParenthesesBRUTEFORCE(string str)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int CalculateLongestValidParentheses(int startIndex, string str)
        {
            var currentLength = 1;
            var longest = -1;
            var stack = new Stack<char>();
            var currentIndex = startIndex + 1;
            var isValid = true;

            stack.Push(str[startIndex]);

            while (currentIndex < str.Length && isValid)
            {
                var actual = str[currentIndex];

                if (actual == ')' && stack.Count == 0)
                {
                    isValid = false;
                }

                else if (actual == '(')
                {
                    currentLength++;
                    stack.Push(actual);
                }
                else //actual == ')'
                {
                    currentLength++;
                    stack.Pop();

                    if (stack.Count == 0)
                    {
                        longest = currentLength;
                    }
                }

                currentIndex++;
            }

            return longest;
        }
        /// <summary>
        /// ////////////////////////
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int LongestValidParenthesesUSINGSTACK(string str)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        //dp 

        public int LongestValidParenthesesDP(string s)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
