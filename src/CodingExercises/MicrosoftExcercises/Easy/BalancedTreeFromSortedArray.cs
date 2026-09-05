/*
 =======================================================================================
 CHALLENGE: BalancedTreeFromSortedArray
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BalancedTreeFromSortedArray problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BalancedTreeFromSortedArrayTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class BalancedTreeFromSortedArray
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        public TreeNode SortedArrayToBST(int[] nums, int low, int high)
        {
            if (low > high)
            {
                return null;
            }
            else if (low == high)
            {
                return new TreeNode(nums[low]);
            }
            else
            {
                var mid = low + (high - low) / 2;
                var left = SortedArrayToBST(nums, low, mid - 1);
                var right = SortedArrayToBST(nums, mid + 1, high);

                return new TreeNode(nums[mid], left, right);
            }
        }
    }
}
