/*
 =======================================================================================
 CHALLENGE: Enums (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Enums.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.OOD.EnumsTests
 =======================================================================================
*/

﻿namespace CodingExercises.OOD.StackOverflow
{
    public enum QuestionStatus
    {
        OPEN,
        CLOSED,
        ON_HOLD,
        DELETED
    }

    public enum QuestionClosingRemark
    {
        DUPLICATE,
        OFF_TOPIC,
        TOO_BROAD,
        NOT_CONSTRUCTIVE,
        NOT_A_REAL_QUESTION,
        PRIMARILY_OPINION_BASED
    }

    public enum AccounStatus 
    {
        ACTIVE,
        CLOSED,
        CANCELED,
        BLACKLISTED,
        BLOCKED
    }
}
