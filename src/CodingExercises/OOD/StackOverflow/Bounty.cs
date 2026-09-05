/*
 =======================================================================================
 CHALLENGE: Bounty (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Bounty.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.OOD.BountyTests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.OOD.StackOverflow
{
    public class Bounty
    {
        public int Reputation { get; set; }

        public DateTime ExpireIn { get; set; }
    }
}