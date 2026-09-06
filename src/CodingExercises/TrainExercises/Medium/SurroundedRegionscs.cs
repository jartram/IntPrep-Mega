/*
 =======================================================================================
 CHALLENGE: SurroundedRegionscs
 CATEGORY: TrainExercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SurroundedRegionscs problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.SurroundedRegionscsTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.TrainExercises.Medium
{
    public class SurroundedRegionscs
    {
        public void Solve(char[][] board)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void MarkNotSurrounded(char[][] board, int i, int j)
        {
            if (board[i][j] == 'O')
            {
                var queue = new Queue<int[]>();

                queue.Enqueue(new int[] { i, j });

                while (queue.Count > 0)
                {
                    var actual = queue.Dequeue();

                    if (board[actual[0]][actual[1]] == '?')  // ------------> Instructive line!!! skip duplicates
                    {
                        continue;
                    }

                    board[actual[0]][actual[1]] = '?';

                    AddNeighbours(board, actual[0], actual[1], queue);
                }
            }
        }

        private void AddNeighbours(char[][] board, int i, int j, Queue<int[]> queue)
        {
            if (i > 0 && board[i - 1][j] == 'O')
            {
                queue.Enqueue(new int[] { i - 1, j });
            }

            if (j > 0 && board[i][j - 1] == 'O')
            {
                queue.Enqueue(new int[] { i, j - 1 });
            }

            if (i < board.Length - 1 && board[i + 1][j] == 'O')
            {
                queue.Enqueue(new int[] { i + 1, j });
            }

            if (j < board[i].Length - 1 && board[i][j + 1] == 'O')
            {
                queue.Enqueue(new int[] { i, j + 1 });
            }
        }
    }
}
