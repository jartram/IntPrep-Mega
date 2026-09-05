using System;
using System.Collections.Generic;

namespace CodingExercises.Solutions.MicrosoftExcercises.Medium
{
    public class FindAllDuplicates
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            var duplicates = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var nextIndex = Math.Abs(nums[i]) - 1;

                if (nums[nextIndex] < 0)
                {
                    duplicates.Add(nextIndex + 1);
                }
                else
                {
                    nums[nextIndex] = nums[nextIndex] * -1;
                }
            }

            return duplicates;
        }
    }
}
