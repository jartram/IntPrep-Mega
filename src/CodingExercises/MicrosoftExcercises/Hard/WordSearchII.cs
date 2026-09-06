/*
 =======================================================================================
 CHALLENGE: Solution
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Solution problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SolutionTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class Solution
    {
        private int[] Ys = new int[] { -1, 0, 0, 1 };
        private int[] Xs = new int[] { 0, -1, 1, 0 };
        public IList<string> FindWords(char[][] board, string[] words)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        private void Backtrack(int startRow, int startCol, TrieNode currentNode, char[][] board, IList<string> result)
        {
            if (currentNode.Word != "")
            {
                result.Add(currentNode.Word);
            }
            var neighbours = GetNeighbours(startRow, startCol, board);
            foreach (var neighbour in neighbours)
            {
                var neighbourRow = neighbour[0];
                var neighbourCol = neighbour[1];
                var aux = board[neighbourRow][neighbourCol];
                if (currentNode.Contains(aux))
                {
                    board[neighbourRow][neighbourCol] = '*';
                    Backtrack(neighbourRow, neighbourCol, currentNode.GetChildren(aux), board, result);
                    board[neighbourRow][neighbourCol] = aux;
                }
            }
        }
        private IList<int[]> GetNeighbours(int row, int col, char[][] board)
        {
            IList<int[]> neighbours = new List<int[]>();
            for (int index = 0; index < Xs.Length; index++)
            {
                var newRow = row + Ys[index];
                var newCol = col + Xs[index];
                if (newRow >= 0 && newRow < board.Length
                  && newCol >= 0 && newCol < board[newRow].Length
                  && board[newRow][newCol] != '*')
                {
                    neighbours.Add(new int[] { newRow, newCol });
                }
            }
            return neighbours;
        }
    }
    public class TrieNode
    {
        public string Word { get; set; }
        public Dictionary<char, TrieNode> Links { get; set; }
        public TrieNode()
        {
            Links = new Dictionary<char, TrieNode>();
            Word = string.Empty;
        }
        public bool Contains(char ch)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        public TrieNode GetChildren(char cr)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        public TrieNode AddOrReturnExisting(char ch)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
    public class Trie
    {
        public TrieNode Root { get; set; }
        public Trie()
        {
            Root = new TrieNode();
        }
        public void AddWord(string word)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
