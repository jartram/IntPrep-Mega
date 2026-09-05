/*
 =======================================================================================
 CHALLENGE: RemoveDuplicatesStringLexo
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RemoveDuplicatesStringLexo problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RemoveDuplicatesStringLexoTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class RemoveDuplicatesStringLexo
    {
        public string RemoveDuplicateLetters(string str)
        {
            var counts = new int[26];
            var sb = new StringBuilder();
            var visited = new HashSet<char>();

            foreach (var currentChar in str)
            {
                counts[currentChar - 'a']++;
            }

            for (var currentIndex = 0; currentIndex < str.Length; currentIndex++)
            {
                var currentChar = str[currentIndex];
                counts[currentChar - 'a']--;

                if (visited.Contains(currentChar))
                {
                    continue;
                }

                while (sb.Length > 0 &&
                      sb[sb.Length - 1] > currentChar &&
                      counts[sb[sb.Length - 1] - 'a'] > 0)
                {
                    visited.Remove(sb[sb.Length - 1]);
                    sb.Length--;
                }

                sb.Append(currentChar);
                visited.Add(currentChar);
            }

            return sb.ToString();
        }
    }
}
