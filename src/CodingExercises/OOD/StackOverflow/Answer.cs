/*
 =======================================================================================
 CHALLENGE: Answer (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Answer.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.OOD.AnswerTests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.OOD.StackOverflow
{
    public class Answer
    {
        public string AnswerText { get; set; }

        public bool Accepted { get; set; }

        public int VoteCount { get; set; }

        public int FlagCount { get; set; }

        public DateTime Creation { get; set; }

        public Member Owner { get; set; }
    }
}
