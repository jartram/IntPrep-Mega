/*
 =======================================================================================
 CHALLENGE: CalendarI
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CalendarI problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.CalendarITests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CalendarI
    {
        private List<int[]> books;

        public CalendarI()
        {
            books = new List<int[]>();
        }

        public bool Book(int start, int end)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool Avaliable(int[] book, int start, int end)
        {
            return !(book[0] < end && start < book[1]);
        }
    }
}
