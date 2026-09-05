/*
 =======================================================================================
 CHALLENGE: MajorityElement
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MajorityElement problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MajorityElementTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class MajorityElement
    {
        public int Solve(int[] nums)
        {
            int? candidate = null;
            int count = 0;

            foreach (var num in nums)
            {
                if (candidate == null)
                {
                    candidate = num;
                    count++;
                }
                else if (num == candidate)
                {
                    count++;
                }
                else
                {
                    count--;

                    if (count == 0)
                    {
                        candidate = num;
                        count = 1;
                    }
                }
            }

            return candidate.Value;
        }
    }
}
