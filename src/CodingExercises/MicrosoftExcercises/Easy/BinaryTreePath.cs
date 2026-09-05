/*
 =======================================================================================
 CHALLENGE: BinaryTreePath
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BinaryTreePath problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BinaryTreePathTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class BinaryTreePath
    {
        public IList<string> result;

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            result = new List<string>();
            BinaryTreePathsAux(root, "");
            return result;
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
