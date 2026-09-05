/*
 =======================================================================================
 CHALLENGE: InorderTraversal
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the InorderTraversal problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.InorderTraversalTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class InorderTraversal
    {
        public IList<int> Solve(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            var list = new List<int>();
            var current = root;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                current = stack.Pop();

                list.Add(current.val);

                current = current.right;
            }

            return list;
        }
    }
}
