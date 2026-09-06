/*
 =======================================================================================
 CHALLENGE: Shuffle
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Shuffle problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.ShuffleTests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Shuffle
    {
        private int[] array;
        private readonly int[] original;
        private Random rnd;

        public Shuffle(int[] nums)
        {
            rnd = new Random();
            array = nums;
            original = (int[])array.Clone();
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Returns a random shuffling of the array. */
        public int[] Solve()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int RandomInRange(int i, int j)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Swap(int i, int j)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
