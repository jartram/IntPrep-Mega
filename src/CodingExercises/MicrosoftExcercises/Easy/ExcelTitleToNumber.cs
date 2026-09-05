/*
 =======================================================================================
 CHALLENGE: ExcelTitleToNumber
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ExcelTitleToNumber problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ExcelTitleToNumberTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class ExcelTitleToNumber
    {
        public int TitleToNumber(string columnTitle)
        {
            var result = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                result = result * 26 + (columnTitle[i] - 'A' + 1);
            }

            return result;
        }
    }
}
