/*
 =======================================================================================
 CHALLENGE: ValidSudoku
 CATEGORY: CommonExercises / Easy-Array
 SOURCE: https://leetcode.com/problems/valid-sudoku
 
 DESCRIPTION:
 Solve the ValidSudoku problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.ValidSudokuTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.CommonExercises.Easy_Array
{
    //https://leetcode.com/problems/valid-sudoku
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool SameBox(char actual, int i, int j, Dictionary<char, int>[] columns)
        {
            var actualBox = CalculateBox(i, j);
            int currentBox;
            if (j <= 2)
            {
                if (columns[0].TryGetValue(actual, out currentBox) && currentBox == actualBox)
                {
                    return true;
                }
                if (columns[1].TryGetValue(actual, out currentBox) && currentBox == actualBox)
                {
                    return true;
                }
                if (columns[2].TryGetValue(actual, out currentBox) && currentBox == actualBox)
                {
                    return true;
                }
            }
            else if (j <= 5)
            {
                if (columns[3].TryGetValue(actual, out currentBox) && currentBox == actualBox)
                {
                    return true;
                }
                if (columns[4].TryGetValue(actual, out currentBox) && currentBox == actualBox)
                {
                    return true;
                }
                if (columns[5].TryGetValue(actual, out currentBox) && currentBox == actualBox)
                {
                    return true;
                }
            }
            else
            {
                if (columns[6].TryGetValue(actual, out currentBox) && currentBox == actualBox)
                {
                    return true;
                }
                if (columns[7].TryGetValue(actual, out currentBox) && currentBox == actualBox)
                {
                    return true;
                }
                if (columns[8].TryGetValue(actual, out currentBox) && currentBox == actualBox)
                {
                    return true;
                }
            }

            return false;
        }

        private int CalculateBox(int i, int j)
        {
            if (i >= 0 && i <= 2 && j >= 0 && j <= 2)
            {
                return 1;
            }
            if (i >= 3 && i <= 5 && j >= 0 && j <= 2)
            {
                return 2;
            }
            if (i >= 6 && i <= 8 && j >= 0 && j <= 2)
            {
                return 3;
            }
            //-----------------
            if (i >= 3 && i <= 5 && j >= 0 && j <= 2)
            {
                return 4;
            }
            if (i >= 3 && i <= 5 && j >= 3 && j <= 5)
            {
                return 5;
            }
            if (i >= 3 && i <= 5 && j >= 6 && j <= 8)
            {
                return 6;
            }
            //------------------
            if (i >= 6 && i <= 8 && j >= 0 && j <= 2)
            {
                return 7;
            }
            if (i >= 6 && i <= 8 && j >= 3 && j <= 5)
            {
                return 8;
            }
            if (i >= 6 && i <= 8 && j >= 6 && j <= 8)
            {
                return 9;
            }
            return 1;
        }
    }
}
