/*
 =======================================================================================
 CHALLENGE: TicTacToeDesign
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the TicTacToeDesign problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.TicTacToeDesignTests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class TicTacToeDesign
    {
        public class TicTacToe
        {
            private int[,] table;
            private int N;

            public TicTacToe(int n)
            {
                table = new int[n, n];
                N = n;
            }

            public int Move(int row, int col, int player)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            private int CheckHorizontal(int row, int col, int player)
            {
                var consecutive = 0;
                for (int i = col + 1; i < N && table[row, i] == player; i++)
                {
                    consecutive++;
                }

                for (int i = col - 1; i >= 0 && table[row, i] == player; i--)
                {
                    consecutive++;
                }

                if (consecutive == N - 1)
                {
                    return player;
                }

                return 0;
            }

            private int CheckVertical(int row, int col, int player)
            {
                var consecutive = 0;

                for (int i = row + 1; i < N && table[i, col] == player; i++)
                {
                    consecutive++;
                }

                for (int i = row - 1; i >= 0 && table[i, col] == player; i--)
                {
                    consecutive++;
                }

                if (consecutive == N - 1)
                {
                    return player;
                }

                return 0;
            }

            private int CheckDiagonal(int row, int col, int player)
            {
                var consecutive = 0;
                var i = row + 1;
                var j = col - 1;

                while (i < N && j >= 0 && table[i, j] == player)
                {
                    consecutive++;
                    i++;
                    j--;
                }

                i = row - 1;
                j = col + 1;

                while (j < N && i >= 0 && table[i, j] == player)
                {
                    consecutive++;
                    i--;
                    j++;
                }

                if (consecutive == N - 1)
                {
                    return player;
                }

                return 0;
            }

            private int CheckAntiDiagonal(int row, int col, int player)
            {
                var consecutive = 0;
                var i = row + 1;
                var j = col + 1;

                while (i < N && j < N && table[i, j] == player)
                {
                    consecutive++;
                    i++;
                    j++;
                }

                i = row - 1;
                j = col - 1;

                while (j >= 0 && i >= 0 && table[i, j] == player)
                {
                    consecutive++;
                    j--;
                    i--;
                }

                if (consecutive == N - 1)
                {
                    return player;
                }

                return 0;
            }
        }

        public class OptimizedApproach
        {
            private int[] rows;
            private int[] cols;
            private int antiDiagonal;
            private int diagonal;
            private int N;

            /** Initialize your data structure here. */
            public OptimizedApproach(int n)
            {
                rows = new int[n];
                cols = new int[n];
                antiDiagonal = 0;
                diagonal = 0;
                N = n;
            }

            /** Player {player} makes a move at ({row}, {col}).
                @param row The row of the board.
                @param col The column of the board.
                @param player The player, can be either 1 or 2.
                @return The current winning condition, can be either:
                        0: No one wins.
                        1: Player 1 wins.
                        2: Player 2 wins. */
            public int Move(int row, int col, int player)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        }
    }
}
