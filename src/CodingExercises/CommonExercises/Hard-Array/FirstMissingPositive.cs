/*
 =======================================================================================
 CHALLENGE: FirstMissingPositive
 CATEGORY: CommonExercises / Hard-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FirstMissingPositive problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.FirstMissingPositiveTests
 =======================================================================================
*/

using System;
using System.Linq;

namespace CodingExercises.CommonExercises.Hard_Array
{
    public class FirstMissingPositive
    {
        public int Solve(int[] nums)
        {
            nums = nums.Where(num => num > 0).ToHashSet().ToArray();

            Array.Sort(nums);

            for (int i = 1; i < int.MaxValue; i++)
            {
                if (i == nums.Length + 1 || i != nums[i - 1])
                {
                    return i;
                }
            }

            return 301;
        }
    }
}
