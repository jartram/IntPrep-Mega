/*
 =======================================================================================
 CHALLENGE: BuildTreePostorderInorder
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BuildTreePostorderInorder problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.BuildTreePostorderInorderTests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class BuildTreePostorderInorder
    {
        private Dictionary<int, int> inorderPositions;
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        private TreeNode BuildTreeAux(int[] inorder, int[] postorder, int left, int right, ref int postOrderPosition)
        {
            if (left > right)
            {
                return null;
            }

            int rootValue = postorder[postOrderPosition];
            
            postOrderPosition--;
            
            var root = new TreeNode(rootValue);

            root.right = BuildTreeAux(inorder, postorder, inorderPositions[rootValue] + 1, right, ref postOrderPosition);
            root.left = BuildTreeAux(inorder, postorder, left, inorderPositions[rootValue] - 1, ref postOrderPosition);
            return root;
        }
    }
}
