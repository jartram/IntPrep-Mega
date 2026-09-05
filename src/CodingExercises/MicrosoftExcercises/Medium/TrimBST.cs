/*
 =======================================================================================
 CHALLENGE: TrimBST
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the TrimBST problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.TrimBSTTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class TrimBST
    {
        public TreeNode Solve(TreeNode root, int low, int high)
        {
            return PostOrder(root, low, high);
        }

        public TreeNode PostOrder(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return root;
            }
            else
            {
                root.left = PostOrder(root.left, low, high);
                root.right = PostOrder(root.right, low, high);

                if (root.val >= low && root.val <= high)
                {
                    return root;
                }
                else if (root.val < low)
                {
                    return root.right;
                }
                else
                {
                    return root.left;
                }
            }
        }
    }
}
