/*
 =======================================================================================
 CHALLENGE: Member (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Member.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.OOD.MemberTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.OOD.StackOverflow
{
    public class Member
    {
        public Account Account { get; set; }

        public IEnumerable<Badge> Badges { get; set; }

        public Member()
        {
        }

        public bool AddQuestion(Question question) 
        {
            return false;
        }

        public bool AddTag(Tag question)
        {
            return false;
        }
    }
}
