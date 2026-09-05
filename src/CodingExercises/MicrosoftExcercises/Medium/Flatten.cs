/*
 =======================================================================================
 CHALLENGE: Flatten
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Flatten problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FlattenTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Flatten
    {
        public void Solve(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Preorder(root, null);
        }

        public TreeNode Preorder(TreeNode root, TreeNode prev)
        {
            if (root == null)
            {
                return prev;
            }

            var rightMost = Preorder(root.right, prev);
            var leftMost = Preorder(root.left, rightMost);

            root.left = null;
            root.right = leftMost;

            return root;
        }
    }
}
