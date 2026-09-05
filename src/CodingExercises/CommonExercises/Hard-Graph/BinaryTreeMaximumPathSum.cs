/*
 =======================================================================================
 CHALLENGE: BinaryTreeMaximumPathSum
 CATEGORY: CommonExercises / Hard-Graph
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BinaryTreeMaximumPathSum problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.BinaryTreeMaximumPathSumTests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;

namespace CodingExercises.CommonExercises.Hard_Graph
{
    public class BinaryTreeMaximumPathSum
    {
        public class Solution
        {
            public int globalMax = int.MinValue;

            public int MaxPathSum(TreeNode root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            public int DFS(TreeNode root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            public int MaxPathSum2(TreeNode root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            private int DFS2(TreeNode root, ref int max)
            {
                if (root == null)
                {
                    return 0;
                }

                var left = Math.Max(0, DFS2(root.left, ref max));
                var right = Math.Max(0, DFS2(root.right, ref max));

                max = Math.Max(max, left + right + root.val);

                return Math.Max(left, right) + root.val;
            }
        }
    }
}
