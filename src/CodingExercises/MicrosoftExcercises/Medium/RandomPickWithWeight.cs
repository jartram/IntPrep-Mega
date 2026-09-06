/*
 =======================================================================================
 CHALLENGE: RandomPickWithWeight
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RandomPickWithWeight problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RandomPickWithWeightTests
 =======================================================================================
*/

﻿using System;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class RandomPickWithWeight
    {
        private int[] _weightSum;
        private Random _rnd = new Random();

        public RandomPickWithWeight(int[] w)
        {
            _weightSum = new int[w.Length];
            int max = 0;
            for (int i = 0; i < w.Length; i++)
            {
                max += w[i];
                _weightSum[i] = max;
            }
        }

        public int PickIndex()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
