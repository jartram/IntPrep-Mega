/*
 =======================================================================================
 CHALLENGE: FindCelebrity
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindCelebrity problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FindCelebrityTests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class FindCelebrity
    {
        public int Solve(int n)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool Knows(int candidate, int i)
        {
            throw new NotImplementedException();
        }

        private int CheckCelebrity(int totalCandidates, int candidate)
        {
            for (int i = 0; i < totalCandidates; i++)
            {
                if (i == candidate)
                {
                    continue;
                }

                if (!Knows(i, candidate) || Knows(candidate, i))
                {
                    return -1;
                }
            }

            return candidate;
        }
    }
}
