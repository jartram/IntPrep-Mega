/*
 =======================================================================================
 CHALLENGE: MovingAverage
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MovingAverage problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MovingAverageTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class MovingAverage
    {

        private LinkedList<int> stream;
        private int maxSize;
        private double totalSum;

        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            stream = new LinkedList<int>();
            maxSize = size;
            totalSum = 0;
        }

        public double Next(int val)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
