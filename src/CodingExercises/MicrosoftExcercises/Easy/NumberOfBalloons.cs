/*
 =======================================================================================
 CHALLENGE: NumberOfBalloons
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the NumberOfBalloons problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.NumberOfBalloonsTests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class NumberOfBalloons
    {
        public int MaxNumberOfBalloons(string text)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
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
