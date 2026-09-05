using CodingExercises.Solutions.Shared;
using CodingExercises.Solutions.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.Solutions.MicrosoftExcercises.Medium
{
    public class BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var rightSideView = new List<int>();

            if (root == null)
            {
                return rightSideView;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var queueSize = queue.Count;
                var first = true;
                while (queueSize > 0)
                {
                    if (first)
                    {
                        rightSideView.Add(queue.Peek().val);
                        first = false;
                    }

                    var current = queue.Dequeue();

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }

                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    queueSize--;
                }
            }

            return rightSideView;
        }
    }
}
