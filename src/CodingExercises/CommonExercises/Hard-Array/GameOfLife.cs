/*
 =======================================================================================
 CHALLENGE: GameOfLife
 CATEGORY: CommonExercises / Hard-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the GameOfLife problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.GameOfLifeTests
 =======================================================================================
*/

﻿namespace CodingExercises.CommonExercises.Hard_Array
{
    public class GameOfLife
    {
        public int[,] neighbours;
        
        public void Solve(int[][] board)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void CalculateNeighbours(int[][] board, int i, int j)
        {
            if (i > 0 && board[i - 1][j] == 1)
            {
                neighbours[i, j]++;
            }

            if (j > 0 && board[i][j - 1] == 1)
            {
                neighbours[i, j]++;
            }

            if (i < board.Length - 1 && board[i + 1][j] == 1)
            {
                neighbours[i, j]++;
            }

            if (j < board[i].Length - 1 && board[i][j + 1] == 1)
            {
                neighbours[i, j]++;
            }

            if (i > 0 && j > 0 && board[i - 1][j - 1] == 1)
            {
                neighbours[i, j]++;
            }

            if (i > 0 && j < board[i].Length - 1 && board[i - 1][j + 1] == 1)
            {
                neighbours[i, j]++;
            }

            if (i < board.Length - 1 && j > 0 && board[i + 1][j - 1] == 1)
            {
                neighbours[i, j]++;
            }

            if (i < board.Length - 1 && j < board[i].Length - 1 && board[i + 1][j + 1] == 1)
            {
                neighbours[i, j]++;
            }
        }
    }
}
