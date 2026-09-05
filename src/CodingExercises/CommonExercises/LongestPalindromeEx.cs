/*
 =======================================================================================
 CHALLENGE: LongestPalindromeEx
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LongestPalindromeEx problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.LongestPalindromeExTests
 =======================================================================================
*/

namespace CodingExercises.Exercises
{
    public class LongestPalindromeEx
    {
        public string LongestPalindrome(string s)
        {
            var result = "";

            for (int i = 0; i < s.Length; i++)
            {
                var actualPalindrome = CalculatePalindrome(s, i);

                if (actualPalindrome.Length > result.Length)
                {
                    result = actualPalindrome;
                }
            }

            return result;
        }

        private string CalculatePalindrome(string str, int i)
        {
            var odd = CalculatePalindrome(str, i - 1, i + 1);
            var even = CalculatePalindrome(str, i, i + 1);

            return odd.Length > even.Length ? odd : even;
        }

        private string CalculatePalindrome(string str, int left, int right)
        {
            bool isPalindrome = true;

            while (left >= 0 && right < str.Length && isPalindrome)
            {
                if (isPalindrome = str[left] == str[right])
                {
                    left--;
                    right++;
                }
            }

            return str.Substring(left + 1, (right - 1) - (left + 1) + 1);
        }
    }
}
