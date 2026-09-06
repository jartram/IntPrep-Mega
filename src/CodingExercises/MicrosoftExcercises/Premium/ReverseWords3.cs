/*
 =======================================================================================
 CHALLENGE: ReverseWords3
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ReverseWords3 problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ReverseWords3Tests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class ReverseWords3
    {
        public void ReverseWords(char[] s)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        private void Reverse(char[] s, int left, int right)
        {
            while (left < right)
            {
                var aux = s[left];
                s[left] = s[right];
                s[right] = aux;
                left++;
                right--;
            }
        }
    }
}
