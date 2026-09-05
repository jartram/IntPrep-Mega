/*
 =======================================================================================
 CHALLENGE: SQRT
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SQRT problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SQRTTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class SQRT
    {
        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            long low = 1;
            long high = (int.MaxValue / 2) + 1;

            while (low < high)
            {
                long mid = low + (high - low) / 2;
                long result = mid * mid;

                if (result == x)
                {
                    return (int)mid;
                }
                else if (result > x)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return (int)low - 1;
        }
    }
}
