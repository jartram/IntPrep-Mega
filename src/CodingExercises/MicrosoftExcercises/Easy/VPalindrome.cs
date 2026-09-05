/*
 =======================================================================================
 CHALLENGE: VPalindrome
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the VPalindrome problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.VPalindromeTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class VPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var i = 0;
            var j = s.Length - 1;

            while (i < j)
            {
                while (!char.IsLetterOrDigit(s[i]) && i < j)
                {
                    i++;
                }

                while (!char.IsLetterOrDigit(s[j]) && i < j)
                {
                    j--;
                }

                if (char.ToLower(s[i]) != char.ToLower(s[j]))
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
