/*
 =======================================================================================
 CHALLENGE: MinStack
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MinStack problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MinStackTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class MinStack
    {

        private LinkedList<int> minStack = new LinkedList<int>();
        private int min = int.MaxValue;

        /** initialize your data structure here. */
        public MinStack()
        {
            minStack = new LinkedList<int>();
            min = int.MaxValue;
        }

        public void Push(int x)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Pop()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int Top()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int GetMin()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
