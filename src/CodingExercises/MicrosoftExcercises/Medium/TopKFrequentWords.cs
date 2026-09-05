/*
 =======================================================================================
 CHALLENGE: TopKFrequentWords
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the TopKFrequentWords problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.TopKFrequentWordsTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class TopKFrequentWords
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var frequencies = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word] += 1;
                }
                else
                {
                    frequencies.Add(word, 1);
                }
            }

            return frequencies.OrderByDescending(key => key.Value)
                .ThenBy(key => key.Key)
                .Take(k)
                .Select(key => key.Key)
                .ToList();
        }
    }
}
