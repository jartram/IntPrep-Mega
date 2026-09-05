/*
 =======================================================================================
 CHALLENGE: FreqStack
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FreqStack problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FreqStackTests
 =======================================================================================
*/

using System.Collections.Generic;

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
            var frequency = freqs.ContainsKey(val) ? freqs[val] + 1 : 1;

            if (!stacks.ContainsKey(frequency))
            {
                maxFrequency = frequency;
                stacks.Add(frequency, new Stack<int>());
            }

            stacks[frequency].Push(val);
            freqs[val] = frequency;
        }

        public int Pop()
        {
            var pop = stacks[maxFrequency].Pop();

            freqs[pop]--;

            if (freqs[pop] == 0)
            {
                freqs.Remove(pop);
            }

            if (stacks[maxFrequency].Count == 0)
            {
                stacks.Remove(maxFrequency);
                maxFrequency--;
            }

            return pop;
        }
    }
}
