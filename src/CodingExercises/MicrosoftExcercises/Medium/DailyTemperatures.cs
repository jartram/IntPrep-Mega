/*
 =======================================================================================
 CHALLENGE: DailyTemperaturesClass
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DailyTemperaturesClass problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.DailyTemperaturesTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class DailyTemperaturesClass
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
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
