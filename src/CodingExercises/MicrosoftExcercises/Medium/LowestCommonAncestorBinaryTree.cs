/*
 =======================================================================================
 CHALLENGE: LowestCommonAncestorBinaryTree
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LowestCommonAncestorBinaryTree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LowestCommonAncestorBinaryTreeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class LowestCommonAncestorBinaryTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            if (p == root || q == root)
            {
                return root;
            }

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null)
            {
                return root;
            }

            return left ?? right;
        }
    }
}
