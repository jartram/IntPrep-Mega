/*
 =======================================================================================
 CHALLENGE: BinaryTreePath
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BinaryTreePath problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.BinaryTreePathTests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class BinaryTreePath
    {
        public IList<string> result;

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void BinaryTreePathsAux(TreeNode root, string path)
        {
            if (root != null)
            {
                if (root.left == null && root.right == null)
                {
                    path += $"{root.val}";
                    result.Add(path);
                }
                path += $"{root.val}->";
                if (root.left != null)
                {
                    BinaryTreePathsAux(root.left, path);
                }
                if (root.right != null)
                {
                    BinaryTreePathsAux(root.right, path);
                }
            }
        }
    }
}
