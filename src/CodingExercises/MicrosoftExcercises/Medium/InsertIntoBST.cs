/*
 =======================================================================================
 CHALLENGE: InsertIntoBST
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the InsertIntoBST problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.InsertIntoBSTTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class InsertIntoBST
    {
        public TreeNode Solve(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);
            }

            TreeNode prev = null;
            var current = root;
            bool isLeft = false;

            while (current != null)
            {
                prev = current;

                if (current.val > val)
                {
                    current = current.left;
                    isLeft = true;
                }
                else
                {
                    current = current.right;
                    isLeft = false;
                }
            }

            if (isLeft)
            {
                prev.left = new TreeNode(val);
            }
            else
            {
                prev.right = new TreeNode(val);
            }

            return root;
        }
    }
}
