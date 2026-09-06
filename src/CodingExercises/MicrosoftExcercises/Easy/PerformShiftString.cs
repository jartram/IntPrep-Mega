/*
 =======================================================================================
 CHALLENGE: PerformShiftString
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PerformShiftString problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.PerformShiftStringTests
 =======================================================================================
*/

﻿using System;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class PerformShiftString
    {
        public string StringShift(string s, int[][] shifts)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private string GetShiftedString(string s, bool isLeft, int total)
        {
            var shifted = new StringBuilder();

            if (isLeft)
            {
                for (int i = total; i < total + s.Length; i++)
                {
                    var index = i % s.Length;

                    shifted.Append(s[index]);
                }
            }
            else
            {
                var start = (s.Length - total);

                for (int i = start; i < start + s.Length; i++)
                {
                    var index = i % s.Length;

                    shifted.Append(s[index]);
                }
            }

            return shifted.ToString();
        }
    }
}
