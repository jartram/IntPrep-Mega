/*
 =======================================================================================
 CHALLENGE: SlidingWindowMaximum
 CATEGORY: CommonExercises / Hard-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SlidingWindowMaximum problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.SlidingWindowMaximumTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.CommonExercises.Hard_Array
{
    public class SlidingWindowMaximum
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            var result = new int[nums.Length - k + 1];
            var queue = new LinkedList<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (queue.Any() && queue.First.Value + k == i)
                {
                    queue.RemoveFirst();
                }

                while (queue.Any() && nums[i] > nums[queue.Last.Value])
                {
                    queue.RemoveLast();
                }

                queue.AddLast(i);

                if (i + 1 - k >= 0)
                {
                    result[i + 1 - k] = nums[queue.First.Value];
                }
            }

            return result;
        }
    }
}
