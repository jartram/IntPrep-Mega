/*
 =======================================================================================
 CHALLENGE: GasStation
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the GasStation problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.GasStationTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var diff = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                diff += gas[i] - cost[i];
            }

            if (diff < 0)
            {
                return -1;
            }

            var index = 0;
            var tank = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                tank += gas[i] - cost[i];

                if (tank < 0)
                {
                    tank = 0;
                    index = i + 1;
                }
            }

            return index;
        }
    }
}
