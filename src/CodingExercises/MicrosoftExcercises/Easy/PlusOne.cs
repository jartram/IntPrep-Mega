/*
 =======================================================================================
 CHALLENGE: PlusOne
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PlusOne problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.PlusOneTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class PlusOne
    {
        public int[] Solve(int[] digits)
        {
            var carry = 1;

            var list = new LinkedList<int>();

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var sum = digits[i] + carry;


                list.AddFirst(sum % 10);
                carry = sum / 10;
            }

            if (carry > 0)
            {
                list.AddFirst(carry);
            }

            return list.ToArray();
        }
    }
}
