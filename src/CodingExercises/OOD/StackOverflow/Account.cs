/*
 =======================================================================================
 CHALLENGE: Account (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Account.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.OOD.AccountTests
 =======================================================================================
*/

﻿namespace CodingExercises.OOD.StackOverflow
{
    public class Account
    {
        public long Id { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Reputation { get; set; }

        public bool ResetPassword(string newPassword) 
        {
            Password = newPassword;

            return true;
        }
    }
}
