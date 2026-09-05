/*
 =======================================================================================
 CHALLENGE: LevelOrderTrasversal
 CATEGORY: CommonExercises / Easy-Trees
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LevelOrderTrasversal problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.LevelOrderTrasversalTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.CommonExercises.Easy_Trees
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
