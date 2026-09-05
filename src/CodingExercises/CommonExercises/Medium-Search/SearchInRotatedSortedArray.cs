/*
 =======================================================================================
 CHALLENGE: SearchInRotatedSortedArray
 CATEGORY: CommonExercises / Medium-Search
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SearchInRotatedSortedArray problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.SearchInRotatedSortedArrayTests
 =======================================================================================
*/

namespace CodingExercises.Exercises.Search
{
    public class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int n = nums.Length;

            if (n == 0)
            {
                return -1;
            }

            int low = 0;
            int high = n - 1;
            int first = nums[0];

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int actual = nums[mid];

                if (actual == target)
                {
                    return mid;
                }

                bool onHighSide = actual >= first; // -----> Indicates in which side of the array i am right now
                bool targetInHighSide = target >= first; // this indicates that the target is on the high side of the array
                                                         // |----high side---||-low side--|
                                                         // [5, 6, 7, 8, 9, 10, 1, 2, 3, 4]

                if (onHighSide == targetInHighSide)
                {
                    if (target < actual)
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else
                {
                    if (onHighSide)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
