/*
 =======================================================================================
 CHALLENGE: IsSymmetric
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the IsSymmetric problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.IsSymmetricTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class IsSymmetric
    {
        public bool Solve(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var n1 = queue.Dequeue();
                var n2 = queue.Dequeue();

                if (n1 == null && n2 == null)
                {
                    continue;
                }

                if ((n1 == null && n2 != null) ||
                   (n1 != null && n2 == null) ||
                   n1.val != n2.val)
                {
                    return false;
                }

                queue.Enqueue(n1.left);
                queue.Enqueue(n2.right);
                queue.Enqueue(n1.right);
                queue.Enqueue(n2.left);
            }

            return true;
        }
    }
}
