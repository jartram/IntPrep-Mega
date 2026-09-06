/*
 =======================================================================================
 CHALLENGE: Tag (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Tag.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.OOD.TagTests
 =======================================================================================
*/

﻿namespace CodingExercises.OOD.StackOverflow
{
    public class Tag
    {
        private string name;
        private string description;
        private long freqDaily;
        private long freqWeekly;
    }
}
