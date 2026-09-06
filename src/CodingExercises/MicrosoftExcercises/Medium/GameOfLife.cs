/*
 =======================================================================================
 CHALLENGE: GameOfLife
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the GameOfLife problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.GameOfLifeTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class GameOfLife
    {
        private int[] Ys = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
        private int[] Xs = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

        public void Solve(int[][] board)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int CalculateNeighbours(int i, int j, int[][] board)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
