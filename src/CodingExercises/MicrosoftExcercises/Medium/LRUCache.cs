/*
 =======================================================================================
 CHALLENGE: LRUCache
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LRUCache problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LRUCacheTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class LRUCache
    {

        private Dictionary<int, int[]> lookup;
        private LinkedList<int[]> cache;
        private int capacity;

        public LRUCache(int capacity)
        {
            lookup = new Dictionary<int, int[]>();
            cache = new LinkedList<int[]>();
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Put(int key, int value)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
