/*
 =======================================================================================
 CHALLENGE: DeepestLeavesSum
 CATEGORY: TrainExercises / DailyChallengesLC
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DeepestLeavesSum problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.DeepestLeavesSumTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.TrainExercises.DailyChallengesLC
{
    public class DeepestLeavesSum
    {
        public int Solve(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var sum = 0;

            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var queueSize = queue.Count;
                sum = 0;

                while (queueSize > 0)
                {
                    var actual = queue.Dequeue();
                    queueSize--;
                    sum += actual.val;

                    if (actual.left != null)
                    {
                        queue.Enqueue(actual.left);
                    }

                    if (actual.right != null)
                    {
                        queue.Enqueue(actual.right);
                    }
                }
            }

            return sum;
        }
    }
}
