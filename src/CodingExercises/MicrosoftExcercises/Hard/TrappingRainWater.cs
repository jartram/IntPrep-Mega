/*
 =======================================================================================
 CHALLENGE: TrappingRainWater
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the TrappingRainWater problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.TrappingRainWaterTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class TrappingRainWater
    {
        public int Trap(int[] heights)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int TrapReview(int[] heights)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }

    public class IndexedHeight
    {
        public int Index { get; set; }

        public int Height { get; set; }

        public IndexedHeight(int index, int height)
        {
            Index = index;
            Height = height;
        }
    }
}
