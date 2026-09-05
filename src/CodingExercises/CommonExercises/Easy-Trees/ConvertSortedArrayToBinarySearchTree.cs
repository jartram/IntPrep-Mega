/*
 =======================================================================================
 CHALLENGE: ConvertSortedArrayToBinarySearchTree
 CATEGORY: CommonExercises / Easy-Trees
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ConvertSortedArrayToBinarySearchTree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.ConvertSortedArrayToBinarySearchTreeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;

namespace CodingExercises.CommonExercises.Easy_Trees
{
    public class ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedArrayToBST(int[] nums, int low, int high)
        {
            if (low > high)
            {
                return null;
            }

            var mid = low + (high - low) / 2;

            Console.WriteLine(nums[mid]);
            var node = new TreeNode(nums[mid]);

            node.left = SortedArrayToBST(nums, low, mid - 1);
            node.right = SortedArrayToBST(nums, mid + 1, high);

            return node;
        }
    }
}
