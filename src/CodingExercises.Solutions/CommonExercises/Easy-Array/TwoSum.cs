using System.Collections.Generic;

namespace CodingExercises.Solutions.CommonExercises.Easy_Array
{
    //https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/546/
    public class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            var hs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hs.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, hs[target - nums[i]] };
                }
                else
                {
                    hs.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
