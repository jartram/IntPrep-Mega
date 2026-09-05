/*
 =======================================================================================
 CHALLENGE: ClosestBinaryTreeValue
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ClosestBinaryTreeValue problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ClosestBinaryTreeValueTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class ClosestBinaryTreeValue
    {
        public int ClosestValue(TreeNode root, double target)
        {
            int val, closest = root.val;
            while (root != null)
            {
                val = root.val;
                closest = Math.Abs(val - target) < Math.Abs(closest - target) ? val : closest;
                root = target < root.val ? root.left : root.right;
            }
            return closest;
        }
    }
}
