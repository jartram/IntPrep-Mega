/*
 =======================================================================================
 CHALLENGE: BinaryTreeRightSideView
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BinaryTreeRightSideView problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BinaryTreeRightSideViewTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
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
