/*
 =======================================================================================
 CHALLENGE: WordBreakII
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the WordBreakII problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.WordBreakIITests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class WordBreakII
    {
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            IList<string> combinations = new List<string>();

            Backtrack(s, 0, wordDict.ToHashSet(), new StringBuilder(), combinations);

            return combinations;
        }

        private void Backtrack(string str, int start, HashSet<string> wordDict, StringBuilder combination, IList<string> combinations)
        {
            if (start == str.Length)
            {
                combinations.Add(combination.ToString().Substring(0, combination.Length - 1));

                return;
            }

            for (int index = start; index <= str.Length; index++)
            {
                var left = str.Substring(start, index - start);

                if (wordDict.Contains(left))
                {
                    combination.Append($"{left} ");
                    Backtrack(str, index, wordDict, combination, combinations);
                    combination.Length -= left.Length + 1;
                }
            }
        }
    }
}
