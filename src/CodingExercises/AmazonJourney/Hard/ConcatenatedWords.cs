/*
 =======================================================================================
 CHALLENGE: Solution
 CATEGORY: AmazonJourney / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Solution problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.AmazonJourney.SolutionTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.AmazonJourney.Hard
{
    public class Solution
    {
        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool IsConcatenatedWord(string word, TrieNode root, int startIndex, int containedWords, bool?[] cache)
        {
            if (startIndex == word.Length && containedWords > 1)
            {
                return true;
            }

            if (cache[startIndex] != null)
            {
                return cache[startIndex].Value;
            }

            var current = root;
            var result = false;

            for (int i = startIndex; i < word.Length && !result; i++)
            {
                var currentChar = word[i];

                if (!current.Links.ContainsKey(currentChar))
                {
                    break;
                }

                current = current.Links[currentChar];

                if (current.Word != "" && current.Word != word)
                {
                    result |= IsConcatenatedWord(word, root, i + 1, containedWords + 1, cache);
                }
            }

            cache[startIndex] = result;

            return result;
        }
    }

    public class Trie
    {
        public TrieNode _root { get; set; }

        public Trie(string[] words)
        {
            _root = new TrieNode();

            BuildTrie(words);
        }

        public void AddWord(string word)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void BuildTrie(string[] words)
        {
            foreach (var word in words)
            {
                AddWord(word);
            }
        }

    }

    public class TrieNode
    {
        public string Word { get; set; }

        public Dictionary<char, TrieNode> Links { get; set; }

        public TrieNode()
        {
            Word = string.Empty;
            Links = new Dictionary<char, TrieNode>();
        }
    }

}
