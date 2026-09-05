/*
 =======================================================================================
 CHALLENGE: FirstBadVersion
 CATEGORY: CommonExercises / Easy-SearchAndSorting
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FirstBadVersion problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.FirstBadVersionTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Easy_SearchAndSorting
{
    public class FirstBadVersion
    {
        public int Solve(int n)
        {
            int low = 1;
            int high = n;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (IsBadVersion(mid) && !IsBadVersion(mid - 1))
                {
                    return mid;
                }
                else if (IsBadVersion(mid))
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return 1;
        }

        private bool IsBadVersion(int mid) // this is implemented on leetcode, for testing can be easily modified
        {
            throw new System.NotImplementedException();
        }
    }
}
