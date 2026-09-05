/*
 =======================================================================================
 CHALLENGE: Solution
 CATEGORY: AmazonJourney / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Solution problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.AmazonJourney.SolutionTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.AmazonJourney.Medium
{
    public class Solution
    {
        public List<int> dijkstra(int vertices, ref List<List<List<int>>> adj, int source)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }

    public class PriorityQueue<K>
    {
        private List<K> data;
        private IComparer<K> comparator;

        public PriorityQueue(IComparer<K> comparator)
        {
            this.comparator = comparator;
            data = new List<K>();
        }

        public int Count()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public K Top()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public K Pop()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Push(K item)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void Swap(int i, int j)
        {
            var aux = data[i];

            data[i] = data[j];
            data[j] = aux;
        }

        private void HeapifyUp()
        {
            var index = data.Count - 1;

            while (index > 0)
            {
                var parentIndex = (index - 1) / 2;

                if (comparator.Compare(data[index], data[parentIndex]) >= 0)
                {
                    return;
                }

                Swap(parentIndex, index);

                index = parentIndex;
            }
        }

        private void HeapifyDown(int lastIndex)
        {
            var index = 0;

            while (true)
            {
                var minIndex = (index * 2) + 1;

                if (minIndex > lastIndex)
                {
                    return;
                }

                var right = minIndex + 1;

                if (right <= lastIndex && comparator.Compare(data[right], data[minIndex]) < 0)
                {
                    minIndex = right;
                }

                if (comparator.Compare(data[index], data[minIndex]) <= 0)
                {
                    return;
                }

                Swap(minIndex, index);
                index = minIndex;
            }
        }
    }

    public class MyComparer : IComparer<(int, int)>
    {
        public int Compare((int, int) A, (int, int) B)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
