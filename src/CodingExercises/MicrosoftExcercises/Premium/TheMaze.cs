/*
 =======================================================================================
 CHALLENGE: TheMaze
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the TheMaze problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.TheMazeTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class TheMaze
    {
        private (int, int)[] directions = new (int, int)[] { (-1, 0), (0, -1), (0, 1), (1, 0) };

        public bool HasPath(int[][] maze, int[] start, int[] destination)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
