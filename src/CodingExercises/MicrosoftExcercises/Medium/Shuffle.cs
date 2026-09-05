/*
 =======================================================================================
 CHALLENGE: Shuffle
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Shuffle problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ShuffleTests
 =======================================================================================
*/

using System;

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
            array = (int[])original.Clone();

            return original;
        }

        /** Returns a random shuffling of the array. */
        public int[] Solve()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                Swap(i, RandomInRange(i, array.Length));
            }

            return array;
        }

        public int RandomInRange(int i, int j)
        {
            return rnd.Next(j - i) + i;
        }

        public void Swap(int i, int j)
        {
            var tmp = array[j];
            array[j] = array[i];
            array[i] = tmp;
        }
    }
}
