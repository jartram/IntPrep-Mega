/*
 =======================================================================================
 CHALLENGE: PeekingIterator
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PeekingIterator problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.PeekingIteratorTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class PeekingIterator
    {
        private IEnumerator<int> _iterator;
        private bool hasNext;

        // iterators refers to the first element of the array.
        public PeekingIterator(IEnumerator<int> iterator)
        {
            // initialize any member here.
            _iterator = iterator;
            hasNext = iterator != null;
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
