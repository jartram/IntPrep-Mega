/*
 =======================================================================================
 CHALLENGE: WordSearch
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the WordSearch problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.WordSearchTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public bool Backtrack(char[][] board, string word, int index, int i, int j)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private List<int[]> GetNeighbours(char[][] matrix, string word, int index, int i, int j)
        {
            var result = new List<int[]>();

            if (i > 0 && matrix[i - 1][j] == word[index])
            {
                result.Add(new int[] { i - 1, j });
            }

            if (j > 0 && matrix[i][j - 1] == word[index])
            {
                result.Add(new int[] { i, j - 1 });
            }

            if (i < matrix.Length - 1 && matrix[i + 1][j] == word[index])
            {
                result.Add(new int[] { i + 1, j });
            }

            if (j < matrix[i].Length - 1 && matrix[i][j + 1] == word[index])
            {
                result.Add(new int[] { i, j + 1 });
            }

            return result;
        }
    }
}
