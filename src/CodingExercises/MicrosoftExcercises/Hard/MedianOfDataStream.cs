/*
 =======================================================================================
 CHALLENGE: MedianFinder
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MedianFinder problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MedianFinderTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class MedianFinder
    {

        private ListNodeCustom _streamHead;
        private int _length;

        /** initialize your data structure here. */
        public MedianFinder()
        {
            _streamHead = new ListNodeCustom(0);
            _length = 0;
        }

        public void AddNum(int num)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public double FindMedian()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }

    public class ListNodeCustom
    {
        public ListNodeCustom Next { get; set; }
        public int Value { get; set; }

        public ListNodeCustom(int val, ListNodeCustom next = null)
        {
            Value = val;
            Next = next;
        }
    }
}
