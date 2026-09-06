/*
 =======================================================================================
 CHALLENGE: AlienDict
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the AlienDict problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.AlienDictTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class AlienDict
    {
        public class Solution
        {
            public string AlienOrder(string[] words)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            private Dictionary<char, IList<char>> BuildGraph(string[] words)
            {
                var trie = BuildTrie(words);

                if (trie == null)
                {
                    return null;
                }

                var graph = new Dictionary<char, IList<char>>();
                var queue = new Queue<TrieNode>();

                queue.Enqueue(trie.root);

                while (queue.Count > 0)
                {
                    var queueSize = queue.Count;

                    while (queueSize > 0)
                    {
                        var actual = queue.Dequeue();

                        var dependecies = new List<char>();

                        if (actual.Value != '$' && actual.Children.Count == 0)
                        {
                            if (!graph.ContainsKey(actual.Value))
                            {
                                graph.Add(actual.Value, new List<char>());
                            }
                        }

                        foreach (var child in actual.Children)
                        {
                            AddDependeciesToGraph(graph, dependecies, child.Value);

                            dependecies.Add(child.Value);

                            queue.Enqueue(child);
                        }

                        queueSize--;
                    }
                }

                return graph;
            }

            private void AddDependeciesToGraph(Dictionary<char, IList<char>> graph,
                                               IList<char> deps,
                                                char node)
            {
                if (!graph.ContainsKey(node))
                {
                    graph.Add(node, new List<char>());
                }

                foreach (var dep in deps)
                {
                    if (!graph.ContainsKey(dep))
                    {
                        graph.Add(dep, new List<char>());
                    }

                    if (!graph[node].Contains(dep))
                    {
                        graph[node].Add(dep);
                    }
                }
            }

            private Trie BuildTrie(string[] words)
            {
                var trie = new Trie();

                foreach (var word in words)
                {
                    if (!trie.AddWord(word))
                    {
                        return null;
                    }
                }

                return trie;
            }
        }

        public class Trie
        {
            public TrieNode root { get; set; }

            public Trie()
            {
                root = new TrieNode('$');
            }

            public bool AddWord(string word)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        }

        public class TrieNode
        {
            public char Value { get; set; }
            public LinkedList<TrieNode> Children { get; set; }

            public TrieNode(char val)
            {
                Value = val;
                Children = new LinkedList<TrieNode>();
            }
        }
    }
}
