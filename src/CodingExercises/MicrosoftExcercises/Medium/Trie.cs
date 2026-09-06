/*
 =======================================================================================
 CHALLENGE: Trie
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Trie problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.TrieTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class Trie
    {

        private TrieNode root;

        /** Initialize your data structure here. */
        public Trie()
        {
            root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private TrieNode searchPrefix(string word)
        {
            var actual = root;

            for (int i = 0; i < word.Length; i++)
            {
                var currentChar = word[i];

                if (actual.ContainsKey(currentChar))
                {
                    actual = actual.Get(currentChar);
                }
                else
                {
                    return null;
                }
            }

            return actual;
        }


        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }

    public class TrieNode
    {
        private Dictionary<char, TrieNode> links;
        private bool isWord;

        public TrieNode()
        {
            links = new Dictionary<char, TrieNode>();
        }

        public bool ContainsKey(char ch)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public TrieNode Get(char ch)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Put(char ch, TrieNode node)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void setEnd()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public bool isEnd()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}

public class Trie
{

    private TrieNode root;
    /** Initialize your data structure here. */
    public Trie()
    {
        root = new TrieNode();
    }

    /** Inserts a word into the trie. */
    public void Insert(string word)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

    /** Returns if the word is in the trie. */
    public bool Search(string word)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string word)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
}

public class TrieNode
{
    public Dictionary<char, TrieNode> Links { get; set; }
    public string Word { get; set; }

    public TrieNode()
    {
        Word = "";
        Links = new Dictionary<char, TrieNode>();
    }

    public TrieNode GetOrInsert(char current)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

    public TrieNode Get(char current)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
}
