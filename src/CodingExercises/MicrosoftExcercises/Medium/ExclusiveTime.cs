/*
 =======================================================================================
 CHALLENGE: ExclusiveTimes
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ExclusiveTimes problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ExclusiveTimesTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class ExclusiveTimes
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }

    public class Interval
    {
        public int FunctionId { get; set; }

        public bool IsStart { get; set; }

        public int Timestamp { get; set; }

        public Interval(string log)
        {
            string[] decoded = log.Split(":");

            FunctionId = int.Parse(decoded[0]);
            IsStart = decoded[1] == "start";
            Timestamp = int.Parse(decoded[2]);
        }
    }
}
