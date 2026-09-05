/*
 =======================================================================================
 CHALLENGE: DeleteNodeInBST
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DeleteNodeInBST problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.DeleteNodeInBSTTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class DeleteNodeInBST
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val > key)
            {
                root.left = DeleteNode(root.left, key);
            }
            else if (root.val < key)
            {
                root.right = DeleteNode(root.right, key);
            }
            else //found it
            {
                if (root.left == null)
                {
                    return root.right;
                }

                if (root.right == null)
                {
                    return root.left;
                }

                var min = root.right;

                while (min.left != null)
                {
                    min = min.left;
                }

                root.val = min.val;

                root.right = DeleteNode(root.right, min.val);
            }

            return root;
        }
    }
}
