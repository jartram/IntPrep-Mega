/*
 =======================================================================================
 CHALLENGE: ReverseInteger
 CATEGORY: CommonExercises / Easy-String
 SOURCE: https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/879/
 
 DESCRIPTION:
 Solve the ReverseInteger problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.ReverseIntegerTests
 =======================================================================================
*/

namespace CodingExercises.CommonExercises.Easy_String
{
    public class ReverseInteger
    {
        //https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/879/
        public int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                // Shitty condition
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
                rev = rev * 10 + pop;
            }
            return rev;
        }
    }
}
