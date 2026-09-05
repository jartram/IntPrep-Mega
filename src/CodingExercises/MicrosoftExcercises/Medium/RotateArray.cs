/*
 =======================================================================================
 CHALLENGE: RotateArray
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RotateArray problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RotateArrayTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            if (k % nums.Length != 0)
            {
                var shifted = 0;
                var i = 0;
                while (shifted < nums.Length)
                {
                    var actualIndex = i;
                    int? prev = null;

                    do
                    {
                        var next = (i + k) % nums.Length;
                        var tmp = nums[next];

                        nums[next] = prev ?? nums[i];

                        prev = tmp;
                        i = next;
                        shifted++;

                    } while (i != actualIndex);

                    i++;
                }
            }
        }
    }
}
