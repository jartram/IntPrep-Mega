/*
 =======================================================================================
 CHALLENGE: RectangleOverlap
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RectangleOverlap problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RectangleOverlapTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class RectangleOverlap
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            if (rec1[0] == rec1[2] || rec1[1] == rec1[3] ||
               rec2[0] == rec2[2] || rec2[1] == rec2[3])
            {
                // the line cannot have positive overlap
                return false;
            }

            return !(rec1[2] <= rec2[0] ||   // left
                     rec1[3] <= rec2[1] ||   // bottom
                     rec1[0] >= rec2[2] ||   // right
                     rec1[1] >= rec2[3]);
        }
    }
}
