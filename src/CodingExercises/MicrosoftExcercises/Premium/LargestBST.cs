/*
 =======================================================================================
 CHALLENGE: LargestBST
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LargestBST problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LargestBSTTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class LargestBST
    {
        public int LargestBSTSubtree(TreeNode root)
        {
            return FindMax(root).count;
        }

        private (int min, int max, int count) FindMax(TreeNode root)
        {
            if (root == null)
            {
                return (int.MaxValue, int.MinValue, 0);
            }

            var left = FindMax(root.left);
            var right = FindMax(root.right);

            if (root.val > left.max && root.val < right.min)
            {
                return (Math.Min(root.val, left.min), Math.Max(root.val, right.max), left.count + right.count + 1);
            }

            return (int.MinValue, int.MaxValue, Math.Max(left.count, right.count));
        }
    }
}
