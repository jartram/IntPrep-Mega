/*
 =======================================================================================
 CHALLENGE: MinDepth
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MinDepth problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MinDepthTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class MinDepth
    {
        public int Solve(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var queue = new Queue<TreeNode>();
            var level = 0;

            queue.Enqueue(root);

            while (queue.Any())
            {
                var queueSize = queue.Count;
                level++;

                while (queueSize > 0)
                {
                    var actual = queue.Dequeue();

                    if (actual.left == null && actual.right == null)
                    {
                        return level;
                    }

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
            }

            return level;
        }
    }
}
