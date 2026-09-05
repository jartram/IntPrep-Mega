/*
 =======================================================================================
 CHALLENGE: Atoi
 CATEGORY: CommonExercises / Easy-String
 SOURCE: https://leetcode.com/problems/string-to-integer-atoi/
 
 DESCRIPTION:
 Solve the Atoi problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.AtoiTests
 =======================================================================================
*/

﻿namespace CodingExercises.CommonExercises.Easy_String
{
    public class Atoi
    {
        //https://leetcode.com/problems/string-to-integer-atoi/
        int result = 0;
        char actual;
        bool signFound = false;
        int sign;
        int i = 0;

        public int MyAtoi(string s)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool ValidChar(char c)
        {
            return char.IsDigit(c) ||
                (c == '+' && !signFound) ||
                (c == '-' && !signFound) ||
                (c == ' ' && !signFound);
        }
    }
}
