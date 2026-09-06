/*
 =======================================================================================
 CHALLENGE: FreqStack
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FreqStack problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.MaxFreqStackTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class FreqStack
    {
        private Dictionary<int, int> freqs;
        private Dictionary<int, Stack<int>> stacks;
        private int maxFrequency;

        public FreqStack()
        {
            freqs = new Dictionary<int, int>();
            stacks = new Dictionary<int, Stack<int>>();
            maxFrequency = 0;
        }

        public void Push(int val)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int Pop()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
