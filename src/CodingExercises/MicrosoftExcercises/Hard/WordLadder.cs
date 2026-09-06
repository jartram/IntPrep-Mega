/*
 =======================================================================================
 CHALLENGE: WordLadder
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the WordLadder problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.WordLadderTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class WordLadder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private Dictionary<string, HashSet<string>> CreateWordSet(IList<string> wordList)
        {
            var wordSet = new Dictionary<string, HashSet<string>>();

            foreach (var currentWord in wordList)
            {
                for (int i = 0; i < currentWord.Length; i++)
                {
                    var leftSide = currentWord.Substring(0, i);
                    var rightSide = currentWord.Substring(i + 1);
                    var encoded = $"{leftSide}*{rightSide}";

                    if (!wordSet.ContainsKey(encoded))
                    {
                        wordSet.Add(encoded, new HashSet<string>());
                    }

                    wordSet[encoded].Add(currentWord);
                }
            }

            return wordSet;
        }

        private void EnqueueNeighbours(string actual,
                                       Dictionary<string, HashSet<string>> wordSet,
                                       HashSet<string> visited,
                                       Queue<string> queue)
        {
            for (int i = 0; i < actual.Length; i++)
            {
                var leftSide = actual.Substring(0, i);
                var rightSide = actual.Substring(i + 1);
                var encoded = $"{leftSide}*{rightSide}";

                if (wordSet.ContainsKey(encoded))
                {
                    foreach (var word in wordSet[encoded])
                    {
                        if (!visited.Contains(word))
                        {
                            queue.Enqueue(word);
                        }
                    }
                }
            }
        }
    }

}
