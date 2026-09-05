/*
 =======================================================================================
 CHALLENGE: BSTFromInorderPreorder
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BSTFromInorderPreorder problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.BSTFromInorderPreorderTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.Exercises
{
    public class BSTFromInorderPreorder
    {
        // Recursive way

        int preorderIndex = 0;
        Dictionary<int, int> inorderPositions;

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            inorderPositions = new Dictionary<int, int>();

            for (int i = 0; i < inorder.Length; i++)
            {
                inorderPositions.Add(inorder[i], i);
            }

            return ArrayToTree(preorder, inorder, 0, preorder.Length - 1);
        }

        private TreeNode ArrayToTree(int[] preorder, int[] inorder, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int rootValue = preorder[preorderIndex++];
            TreeNode root = new TreeNode(rootValue);

            root.left = ArrayToTree(preorder, inorder, left, inorderPositions[rootValue] - 1);
            root.right = ArrayToTree(preorder, inorder, inorderPositions[rootValue] + 1, right);

            return root;
        }
    }
}
