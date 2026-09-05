/*
 =======================================================================================
 CHALLENGE: PascalTriangle
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PascalTriangle problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.PascalTriangleTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            var level = 1;
            List<int> lastLevel = null;

            for (int i = 0; i < numRows; i++)
            {
                var actualLevel = new List<int>();
                for (int j = 0; j < level; j++)
                {
                    if (j == 0 || j == level - 1)
                    {
                        actualLevel.Add(1);
                    }
                    else
                    {
                        actualLevel.Add(lastLevel.ElementAt(j - 1) + lastLevel.ElementAt(j));
                    }
                }

                result.Add(actualLevel);
                lastLevel = actualLevel;
                level++;
            }
            return result;
        }
    }
}
