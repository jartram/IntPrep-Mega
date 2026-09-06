/*
 =======================================================================================
 CHALLENGE: MyHashMap
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MyHashMap problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.MyHashMapTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class MyHashMap
    {

        private int[] map;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            map = new int[1000001];
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
