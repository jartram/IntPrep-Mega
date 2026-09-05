/*
 =======================================================================================
 CHALLENGE: LevelOrder
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LevelOrder problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LevelOrderTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class LevelOrder
    {
        public IList<IList<int>> Solve(TreeNode root)
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
                var queueSize = queue.Count;
                var actualLevel = new List<int>();

                while (queueSize > 0)
                {
                    var actual = queue.Dequeue();

                    actualLevel.Add(actual.val);

                    if (actual.left != null)
                    {
                        queue.Enqueue(actual.left);
                    }

                    if (actual.right != null)
                    {
                        queue.Enqueue(actual.right);
                    }

                    queueSize--;
                }

                result.Add(actualLevel);
            }

            return result;
        }
    }
}
