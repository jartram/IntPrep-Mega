/*
 =======================================================================================
 CHALLENGE: Guest (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Guest.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.OOD.GuestTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.OOD.StackOverflow
{
    class Guest
    {
        public int GuestId { get; set; }

        private ISearch _search;

        public Guest()
        {

        }

        public IEnumerable<Question> GetQuestions(string query) 
        {
            return _search.Search(query);
        }
    }
}
