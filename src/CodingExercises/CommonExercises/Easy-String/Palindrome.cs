/*
 =======================================================================================
 CHALLENGE: Palindrome
 CATEGORY: CommonExercises / Easy-String
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Palindrome problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.PalindromeTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Easy_String
{
    public class Palindrome
    {
        public bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                while (i < j && !char.IsDigit(s[i]) && !char.IsLetter(s[i]))
                {
                    i++;
                }
                while (i < j && !char.IsDigit(s[j]) && !char.IsLetter(s[j]))
                {
                    j--;
                }

                if (i < j && char.ToLower(s[i]) != char.ToLower(s[j]))
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
