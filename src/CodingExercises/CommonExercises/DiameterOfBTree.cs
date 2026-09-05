/*
 =======================================================================================
 CHALLENGE: DiameterOfBTree
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DiameterOfBTree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.DiameterOfBTreeTests
 =======================================================================================
*/

using System;

namespace CodingExercises.Exercises
{
    public class DiameterOfBTree
    {
        private int diameter;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            diameter = 0;

            LongestPath(root);

            return diameter;
        }

        public int LongestPath(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftDepth = LongestPath(root.left);
            var rightDepth = LongestPath(root.right);

            diameter = Math.Max(diameter, leftDepth + rightDepth);

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
