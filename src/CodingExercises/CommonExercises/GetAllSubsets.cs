/*
 =======================================================================================
 CHALLENGE: GetAllSubsets
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the GetAllSubsets problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.GetAllSubsetsTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.Exercises
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
