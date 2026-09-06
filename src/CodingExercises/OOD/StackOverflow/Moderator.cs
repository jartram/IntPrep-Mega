/*
 =======================================================================================
 CHALLENGE: Moderator (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Moderator.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.OOD.ModeratorTests
 =======================================================================================
*/

﻿namespace CodingExercises.OOD.StackOverflow
{
    public class Moderator : Member
    {
        public bool CloseQuestion(Question question)
        {
            return false;
        }

        public bool OpenQuestion(Question question)
        {
            return false;
        }
    }
}
