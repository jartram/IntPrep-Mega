/*
 =======================================================================================
 CHALLENGE: PathSum
 CATEGORY: CommonExercises
 SOURCE: https://leetcode.com/problems/path-sum/submissions/
 
 DESCRIPTION:
 Solve the PathSum problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.PathSumTests
 =======================================================================================
*/

﻿namespace CodingExercises.Exercises
{
    public class PathSum
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        // https://leetcode.com/problems/path-sum/submissions/
        public class Solution
        {
            public bool HasPathSum(TreeNode root, int sum)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        }
    }
}
