/*
 =======================================================================================
 CHALLENGE: VerticalOrder
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the VerticalOrder problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.VerticalOrderTests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class VerticalOrder
    {
        public IList<IList<int>> Solve(TreeNode root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void BuildVerticalOrder(TreeNode root, Dictionary<int, IList<int>> dict)
        {
            var queue = new Queue<(TreeNode, int)>();

            queue.Enqueue((root, 0));

            while (queue.Count > 0)
            {
                var (actual, position) = queue.Dequeue();

                if (!dict.ContainsKey(position))
                {
                    dict.Add(position, new List<int>());
                }

                dict[position].Add(actual.val);

                if (actual.left != null)
                {
                    queue.Enqueue((actual.left, position - 1));
                }

                if (actual.right != null)
                {
                    queue.Enqueue((actual.right, position + 1));
                }
            }
        }
    }
}
