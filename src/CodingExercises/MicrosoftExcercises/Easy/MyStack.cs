/*
 =======================================================================================
 CHALLENGE: MyStack
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MyStack problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.MyStackTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class MyStack
    {
        private Queue<int> stack;
        private Queue<int> queue;

        /** Initialize your data structure here. */
        public MyStack()
        {
            queue = new Queue<int>();
            stack = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Get the top element. */
        public int Top()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
