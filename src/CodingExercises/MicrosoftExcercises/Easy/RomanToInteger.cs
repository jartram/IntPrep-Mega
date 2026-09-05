/*
 =======================================================================================
 CHALLENGE: RomanToInteger
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RomanToInteger problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RomanToIntegerTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var number = 0;
            var dict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            for (int i = 0; i < s.Length; i++)
            {
                var actual = s[i];

                if (i < s.Length - 1 && dict[actual] < dict[s[i + 1]])
                {
                    number -= dict[actual];
                }
                else
                {
                    number += dict[actual];
                }
            }

            return number;
        }
    }
}
