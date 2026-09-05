/*
 =======================================================================================
 CHALLENGE: DistribuiteCoins
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DistribuiteCoins problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.DistribuiteCoinsTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class DistribuiteCoins
    {
        public int Solve(TreeNode root)
        {
            var moves = 0;

            DFS(root, ref moves);

            return moves;
        }

        public int DFS(TreeNode root, ref int moves)
        {
            if (root == null)
            {
                return 0;
            }

            var leftOverload = DFS(root.left, ref moves);
            var rightOverload = DFS(root.right, ref moves);

            moves += Math.Abs(leftOverload) + Math.Abs(rightOverload);

            return leftOverload + rightOverload + root.val - 1;
        }
    }
}
