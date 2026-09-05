/*
 =======================================================================================
 CHALLENGE: SimplifyPath
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SimplifyPath problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SimplifyPathTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class SimplifyPath
    {
        public string Solve(string path)
        {
            var words = new LinkedList<string>();

            int i = 0;

            while (i < path.Length)
            {
                var actualWordSb = new StringBuilder();

                if (path[i] == '/')
                {
                    i++;
                    continue;
                }

                while (i < path.Length && path[i] != '/')
                {
                    actualWordSb.Append(path[i]);
                    i++;
                }

                var actualWord = actualWordSb.ToString();

                if (actualWord == ".")
                {
                    continue;
                }
                else if (actualWord == "..")
                {
                    if (words.Count > 0)
                    {
                        words.RemoveLast();
                    }
                }
                else if (actualWord.Length > 0)
                {
                    words.AddLast(actualWord);
                }
            }

            var index = 0;
            var result = new StringBuilder();

            result.Append("/");

            foreach (var word in words)
            {
                result.Append($"{word}");

                if (index < words.Count - 1)
                {
                    result.Append("/");
                }

                index++;
            }

            return result.ToString();
        }
    }
}
