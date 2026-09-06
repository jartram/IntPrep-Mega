/*
 =======================================================================================
 CHALLENGE: ValidNumber
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ValidNumber problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ValidNumberTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class ValidNumber
    {
        public bool IsNumber(string str)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool IsSign(char c)
        {
            return c == '+' || c == '-';
        }
    }
}
