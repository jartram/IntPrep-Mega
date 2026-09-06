/*
 =======================================================================================
 CHALLENGE: MyCalendarTwo
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MyCalendarTwo problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MyCalendarTwoTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class MyCalendarTwo
    {

        public SortedDictionary<int, int> treeMap { get; set; }

        public MyCalendarTwo()
        {
            treeMap = new SortedDictionary<int, int>();
        }

        public bool Book(int start, int end)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
