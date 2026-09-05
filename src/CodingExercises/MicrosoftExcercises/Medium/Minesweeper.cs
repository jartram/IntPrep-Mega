/*
 =======================================================================================
 CHALLENGE: Minesweeper
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Minesweeper problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MinesweeperTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Minesweeper
    {
        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            if (board[click[0]][click[1]] == 'M')
            {
                board[click[0]][click[1]] = 'X';

                return board;
            }

            var queue = new Queue<int[]>();
            queue.Enqueue(click);

            while (queue.Count > 0)
            {
                var actual = queue.Dequeue();

                if (board[actual[0]][actual[1]] == 'E')
                {
                    var candidates = UpdateBoardAndCalculateNeighbours(board, actual[0], actual[1]);

                    foreach (var candidate in candidates)
                    {
                        queue.Enqueue(candidate);
                    }
                }
            }

            return board;
        }

        public List<int[]> UpdateBoardAndCalculateNeighbours(char[][] board, int i, int j)
        {
            var countMines = 0;
            var candidates = new List<int[]>();

            if (i > 0)
            {
                if (board[i - 1][j] == 'M')
                {
                    countMines++;
                }
                if (board[i - 1][j] == 'E')
                {
                    candidates.Add(new int[] { i - 1, j });
                }
            }

            if (j > 0)
            {
                if (board[i][j - 1] == 'M')
                {
                    countMines++;
                }
                if (board[i][j - 1] == 'E')
                {
                    candidates.Add(new int[] { i, j - 1 });
                }
            }

            if (i < board.Length - 1)
            {
                if (board[i + 1][j] == 'M')
                {
                    countMines++;
                }
                if (board[i + 1][j] == 'E')
                {
                    candidates.Add(new int[] { i + 1, j });
                }
            }

            if (j < board[i].Length - 1)
            {
                if (board[i][j + 1] == 'M')
                {
                    countMines++;
                }
                if (board[i][j + 1] == 'E')
                {
                    candidates.Add(new int[] { i, j + 1 });
                }
            }

            if (i > 0 && j > 0)
            {
                if (board[i - 1][j - 1] == 'M')
                {
                    countMines++;
                }
                if (board[i - 1][j - 1] == 'E')
                {
                    candidates.Add(new int[] { i - 1, j - 1 });
                }
            }

            if (i < board.Length - 1 && j < board[i].Length - 1)
            {
                if (board[i + 1][j + 1] == 'M')
                {
                    countMines++;
                }
                if (board[i + 1][j + 1] == 'E')
                {
                    candidates.Add(new int[] { i + 1, j + 1 });
                }
            }

            if (i > 0 && j < board[i].Length - 1)
            {
                if (board[i - 1][j + 1] == 'M')
                {
                    countMines++;
                }
                if (board[i - 1][j + 1] == 'E')
                {
                    candidates.Add(new int[] { i - 1, j + 1 });
                }
            }

            if (i < board.Length - 1 && j > 0)
            {
                if (board[i + 1][j - 1] == 'M')
                {
                    countMines++;
                }
                if (board[i + 1][j - 1] == 'E')
                {
                    candidates.Add(new int[] { i + 1, j - 1 });
                }
            }

            if (countMines == 0)
            {
                board[i][j] = 'B';
            }
            else
            {
                board[i][j] = (char)('0' + countMines);
            }

            return countMines == 0 ? candidates : new List<int[]>();
        }
    }
}
