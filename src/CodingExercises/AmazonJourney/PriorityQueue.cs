/*
 =======================================================================================
 CHALLENGE: PriorityQueue
 CATEGORY: AmazonJourney
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PriorityQueue problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.AmazonJourney.PriorityQueueTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.AmazonJourney
{
    public class PriorityQueue<K> // min heap
    {
        private List<K> data;
        private IComparer<K> comparator;

        public PriorityQueue(IComparer<K> comparator)
        {
            data = new List<K>();
            this.comparator = comparator;
        }

        public int Count()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public bool IsEmpty()
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

        private void HeapifyUp()
        {
            var index = data.Count - 1;

            while (index > 0)
            {
                var parentIndex = (index - 1) / 2;

                if (comparator.Compare(data[index], data[parentIndex]) >= 0)
                {
                    break;
                }

                Swap(index, parentIndex);
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

                Swap(index, minIndex);

                index = minIndex;
            }
        }

        private void Swap(int i, int j)
        {
            var aux = data[i];

            data[i] = data[j];
            data[j] = aux;
        }
    }
}
