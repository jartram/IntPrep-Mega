using CodingExercises.Solutions.Shared;
using CodingExercises.Solutions.CommonExercises;

namespace CodingExercises.Solutions.MicrosoftExcercises.Medium
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
