/*
 =======================================================================================
 CHALLENGE: Solution
 CATEGORY: TrainExercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Solution problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.SolutionTests
 =======================================================================================
*/

namespace CodingExercises.TrainExercises.Easy
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] shuffle = new int[nums.Length];

            var i = 0;
            var j = nums.Length / 2;
            int x = 0;

            while (x < nums.Length)
            {
                shuffle[x] = nums[i];
                x++;
                i++;
                if (x < nums.Length)
                {
                    shuffle[x] = nums[j];
                    x++;
                    j++;
                }
            }

            return shuffle;
        }
    }
}