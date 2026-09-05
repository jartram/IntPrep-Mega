/*
 =======================================================================================
 CHALLENGE: WordLadderII
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the WordLadderII problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.WordLadderIITests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class WordLadderII
    {
        //TLE
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void EnqueueNeighbours(Queue<List<string>> queue,
                                       Dictionary<string, HashSet<string>> dict,
                                       string word,
                                       List<string> actualList)
        {
            for (int wordIndex = 0; wordIndex < word.Length; wordIndex++)
            {
                var left = word.Substring(0, wordIndex);
                var right = word.Substring(wordIndex + 1);
                var encoded = $"{left}*{right}";

                foreach (var neighbour in dict[encoded])
                {
                    var copy = actualList.ToList();

                    if (!copy.Contains(neighbour))
                    {
                        copy.Add(neighbour);
                        queue.Enqueue(copy);
                    }
                }
            }
        }

        private Dictionary<string, HashSet<string>> GenerateWordDictionary(IList<string> wordList)
        {
            var wordDict = new Dictionary<string, HashSet<string>>();

            foreach (var word in wordList)
            {
                for (int wordIndex = 0; wordIndex < word.Length; wordIndex++)
                {
                    var left = word.Substring(0, wordIndex);
                    var right = word.Substring(wordIndex + 1);
                    var encoded = $"{left}*{right}";

                    if (!wordDict.ContainsKey(encoded))
                    {
                        wordDict.Add(encoded, new HashSet<string>());
                    }

                    wordDict[encoded].Add(word);
                }
            }

            return wordDict;
        }

        public IList<IList<string>> FindLaddersReview(string beginWord, string endWord, IList<string> wordList)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
