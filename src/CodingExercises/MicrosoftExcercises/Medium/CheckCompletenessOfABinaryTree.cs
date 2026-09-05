/*
 =======================================================================================
 CHALLENGE: CheckCompletenessOfABinaryTree
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CheckCompletenessOfABinaryTree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CheckCompletenessOfABinaryTreeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CheckCompletenessOfABinaryTree
    {
        public bool IsCompleteTree(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var queue = new Queue<TreeNode>();
            var missingNode = false;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var queueSize = queue.Count;

                while (queueSize-- > 0)
                {
                    var actual = queue.Dequeue();

                    if ((actual.left == null && actual.right != null) || (actual.left != null && missingNode))
                    {
                        return false;
                    }

                    if (actual.left != null)
                    {
                        queue.Enqueue(actual.left);
                    }

                    if (actual.right != null)
                    {
                        queue.Enqueue(actual.right);
                    }
                    else
                    {
                        missingNode = true;
                    }
                }
            }

            return true;
        }

        public bool IsCompleteTreeEasyMode(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var actual = queue.Dequeue();

                if (actual != null)
                {
                    queue.Enqueue(actual.left);
                    queue.Enqueue(actual.right);
                }
                else
                {
                    while (queue.Count > 0 && queue.Peek() == null)
                    {
                        queue.Dequeue();
                    }

                    if (queue.Count > 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
