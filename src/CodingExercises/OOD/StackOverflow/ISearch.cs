/*
 =======================================================================================
 CHALLENGE: ISearch (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for ISearch.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.OOD.ISearchTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.OOD.StackOverflow
{
    interface ISearch
    {
        IEnumerable<Question> Search(string query);
    }
}
