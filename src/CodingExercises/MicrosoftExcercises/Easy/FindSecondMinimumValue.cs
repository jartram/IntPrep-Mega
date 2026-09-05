/*
 =======================================================================================
 CHALLENGE: FindSecondMinimumValue
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindSecondMinimumValue problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FindSecondMinimumValueTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class FindSecondMinimumValue
    {
        public int Solve(TreeNode root)
        {
            var min1 = long.MaxValue;
            var result = long.MaxValue;

            var stack = new Stack<TreeNode>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                var actual = stack.Pop();

                if (actual.val < min1)
                {
                    result = min1;
                    min1 = actual.val;
                }
                else if (actual.val != min1)
                {
                    result = Math.Min(actual.val, result);
                }

                if (actual.left != null)
                {
                    stack.Push(actual.left);
                    stack.Push(actual.right);
                }
            }

            return result == long.MaxValue ? -1 : (int)result;
        }
    }
}
