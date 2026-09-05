using CodingExercises.Solutions.Shared;
using CodingExercises.Solutions.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.Solutions.CommonExercises.Easy_Trees
{
    public class LevelOrderTrasversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>(); ;
            }

            var result = new List<IList<int>>();
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var actualLevel = new List<int>();
                var queueSize = queue.Count;

                while (queueSize > 0)
                {
                    var actual = queue.Dequeue();
                    actualLevel.Add(actual.val);
                    queueSize--;

                    if (actual.left != null)
                    {
                        queue.Enqueue(actual.left);
                    }

                    if (actual.right != null)
                    {
                        queue.Enqueue(actual.right);
                    }
                }

                result.Add(actualLevel);
            }

            return result;
        }
    }
}
