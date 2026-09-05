/*
 =======================================================================================
 CHALLENGE: NumberOfBalloons
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the NumberOfBalloons problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.NumberOfBalloonsTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class NumberOfBalloons
    {
        public int MaxNumberOfBalloons(string text)
        {
            var pattern = "balloon";
            var freqText = BuildFrequency(text);
            var freqPattern = BuildFrequency(pattern);
            var total = int.MaxValue;

            for (int i = 0; i < 26; i++)
            {
                if (freqPattern[i] > 0)
                {
                    total = Math.Min(total, freqText[i] / freqPattern[i]);
                }
            }

            return total;
        }

        private int[] BuildFrequency(string str)
        {
            var freq = new int[26];

            foreach (var currentChar in str)
            {
                freq[currentChar - 'a']++;
            }

            return freq;
        }
    }
}
