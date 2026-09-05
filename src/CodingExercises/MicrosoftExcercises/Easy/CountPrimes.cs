/*
 =======================================================================================
 CHALLENGE: CountPrimes
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CountPrimes problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CountPrimesTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class CountPrimes
    {
        public int Solve(int n)
        {
            var isPrime = new bool[n];

            var count = 0;

            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
