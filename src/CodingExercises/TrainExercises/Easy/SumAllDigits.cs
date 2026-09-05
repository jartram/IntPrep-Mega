/*
 =======================================================================================
 CHALLENGE: SumAllDigits
 CATEGORY: TrainExercises / Easy
 SOURCE: https://leetcode.com/problems/add-digits/submissions/
 
 DESCRIPTION:
 Solve the SumAllDigits problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.SumAllDigitsTests
 =======================================================================================
*/

namespace CodingExercises.TrainExercises.Easy
{
    public class SumAllDigits
    {
        //https://leetcode.com/problems/add-digits/submissions/
        public int AddDigits(int num)
        {
            var aux = num;

            while (aux > 9)
            {
                var tmp = aux;

                aux = 0;

                while (tmp > 0)
                {
                    aux += tmp % 10;
                    tmp = tmp / 10;
                }
            }

            return aux;
        }
    }
}
