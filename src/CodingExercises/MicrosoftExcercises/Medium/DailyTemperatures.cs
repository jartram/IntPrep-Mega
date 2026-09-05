/*
 =======================================================================================
 CHALLENGE: DailyTemperaturesClass
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DailyTemperaturesClass problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.DailyTemperaturesClassTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class DailyTemperaturesClass
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var stack = new Stack<IndexedTemperature>();
            var index = 0;
            var numberOfDaysToGetWarmer = new int[temperatures.Length];

            while (index < temperatures.Length)
            {
                while (stack.Count > 0 && stack.Peek().Temperature < temperatures[index])
                {
                    var coldDay = stack.Pop();

                    numberOfDaysToGetWarmer[coldDay.Index] = index - coldDay.Index;
                }

                stack.Push(new IndexedTemperature(index, temperatures[index]));

                index++;
            }

            return numberOfDaysToGetWarmer;
        }
    }

    public class IndexedTemperature
    {
        public int Index { get; set; }
        public int Temperature { get; set; }

        public IndexedTemperature(int index, int temperature)
        {
            Index = index;
            Temperature = temperature;
        }
    }
}
