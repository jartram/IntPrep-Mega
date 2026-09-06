/*
 =======================================================================================
 CHALLENGE: SearchArraySortedSecret
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SearchArraySortedSecret problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SearchArraySortedSecretTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class SearchArraySortedSecret
    {
        public int Search(ArrayReader reader, int target)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int GetBound(ArrayReader reader)
        {
            var low = 0;
            var high = 10000;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                var midElement = reader.Get(mid);

                if (midElement != int.MaxValue && reader.Get(mid + 1) == int.MaxValue)
                {
                    return mid;
                }
                else if (midElement == int.MaxValue)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }

        public class ArrayReader
        {
            public int Get(int i) => 1;
        }
    }
}
