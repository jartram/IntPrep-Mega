/*
 =======================================================================================
 CHALLENGE: MaximumDepth
 CATEGORY: CommonExercises
 SOURCE: https://leetcode.com/problems/maximum-depth-of-binary-tree/submissions/
 
 DESCRIPTION:
 Solve the MaximumDepth problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.MaximumDepthTests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.Exercises
{
    public class MaximumDepth
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

        // https://leetcode.com/problems/maximum-depth-of-binary-tree/submissions/

        public int MaxDepth(TreeNode root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int MaxDepthAux(TreeNode root, int sum)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        //Internet solution
        public int MaxDepthAlt(TreeNode root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
