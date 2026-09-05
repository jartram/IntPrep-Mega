/*
 =======================================================================================
 CHALLENGE: BalancedHeightTree
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BalancedHeightTree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BalancedHeightTreeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class BalancedHeightTree
    {
        public bool IsBalanced(TreeNode root)
        {
            return IsBalancedAux(root) != -1;
        }

        public int IsBalancedAux(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                var left = IsBalancedAux(root.left);

                if (left == -1)
                {
                    return -1;
                }

                var right = IsBalancedAux(root.right);

                if (right == -1)
                {
                    return -1;
                }

                if (Math.Abs(left - right) > 1)
                {
                    return -1;
                }

                return Math.Max(left, right) + 1;
            }
        }
    }
}
