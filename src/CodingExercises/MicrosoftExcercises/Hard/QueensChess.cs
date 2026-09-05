/*
 =======================================================================================
 CHALLENGE: QueensChess
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the QueensChess problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.QueensChessTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class QueensChess
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private IList<string> CreateResult(char[,] board)
        {
            var result = new List<string>();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                var sb = new StringBuilder();

                for (int j = 0; j < board.GetLength(0); j++)
                {
                    sb.Append(board[i, j]);
                }

                result.Add(sb.ToString());
            }

            return result;
        }

        private void Backtrack(IList<IList<string>> combinations, int rowStart, char[,] combination, int n)
        {
            if (rowStart == n)
            {
                combinations.Add(CreateResult(combination));

                return;
            }

            for (int currentColumn = 0; currentColumn < n; currentColumn++)
            {
                if (!IsUnderAttack(rowStart, currentColumn, combination, n))
                {
                    combination[rowStart, currentColumn] = 'Q';
                    Backtrack(combinations, rowStart + 1, combination, n);
                    combination[rowStart, currentColumn] = '.';
                }
            }
        }

        private char[,] CreateChessboard(int n)
        {
            var board = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = '.';
                }
            }

            return board;
        }

        public bool IsUnderAttack(int row, int column, char[,] board, int n)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
