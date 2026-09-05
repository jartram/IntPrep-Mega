using System.Collections.Generic;

namespace CodingExercises.Solutions.Exercises
{
    public class GetAllSubsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var subsets = new List<IList<int>>();

            GenerateSubsets(new List<int>(), 0, subsets, nums);

            return subsets;
        }

        private void GenerateSubsets(IList<int> actual, int index, IList<IList<int>> subsets, int[] nums)
        {
            subsets.Add(new List<int>(actual));

            for (int i = index; i < nums.Length; i++)
            {
                actual.Add(nums[i]);

                GenerateSubsets(actual, i + 1, subsets, nums);

                actual.RemoveAt(actual.Count - 1);
            }
        }
    }
}
