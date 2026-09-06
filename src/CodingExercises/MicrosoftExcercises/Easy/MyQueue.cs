/*
 =======================================================================================
 CHALLENGE: MyQueue
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MyQueue problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MyQueueTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class MyQueue
    {

        public Stack<int> stack { get; set; }
        public Stack<int> queue { get; set; }


        /** Initialize your data structure here. */
        public MyQueue()
        {
            stack = new Stack<int>();
            queue = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Get the front element. */
        public int Peek()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
