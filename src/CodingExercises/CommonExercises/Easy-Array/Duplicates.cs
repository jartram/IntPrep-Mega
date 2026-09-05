/*
 =======================================================================================
 CHALLENGE: Duplicates
 CATEGORY: CommonExercises / Easy-Array
 SOURCE: https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/578/
 
 DESCRIPTION:
 Solve the Duplicates problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.DuplicatesTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.CommonExercises.Easy_Array
{
    //https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/578/
    public class Duplicates
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hs = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hs.Contains(nums[i]))
                {
                    return true;
                }

                hs.Add(nums[i]);
            }

            return false;
        }
    }
}
