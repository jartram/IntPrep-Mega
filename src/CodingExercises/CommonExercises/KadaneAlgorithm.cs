/*
 =======================================================================================
 CHALLENGE: KadaneAlgorithm
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the KadaneAlgorithm problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.KadaneAlgorithmTests
 =======================================================================================
*/

using System;

namespace CodingExercises.Exercises
{
    public class KadaneAlgorithm
    {
        // Largest Sum Contiguous Subarray
        public int KadanesAlgorithm(int[] array)
        {
            var currentMax = array[0];
            var globalMax = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                var num = array[i];
                currentMax = Math.Max(num, currentMax + num);
                globalMax = Math.Max(globalMax, currentMax);
            }

            return globalMax;
        }
    }
}
