/*
 =======================================================================================
 CHALLENGE: MaximumScoreAfterSplittingaString
 CATEGORY: TrainExercises / Easy
 SOURCE: https://leetcode.com/problems/maximum-score-after-splitting-a-string/
 
 DESCRIPTION:
 Solve the MaximumScoreAfterSplittingaString problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.MaximumScoreAfterSplittingaStringTests
 =======================================================================================
*/

using System;

namespace CodingExercises.TrainExercises.Easy
{
    // https://leetcode.com/problems/maximum-score-after-splitting-a-string/
    public class MaximumScoreAfterSplittingaString
    {
        public int MaxScore(string s)
        {
            int[] suffixOnes = new int[s.Length];
            int[] suffixZeroes = new int[s.Length];

            if (s[0] == '1')
            {
                suffixOnes[0]++;
            }
            else
            {
                suffixZeroes[0]++;
            }

            for (int i = 1; i < s.Length; i++)
            {
                suffixOnes[i] += suffixOnes[i - 1];
                suffixZeroes[i] += suffixZeroes[i - 1];

                if (s[i] == '1')
                {
                    suffixOnes[i]++;
                }
                else
                {
                    suffixZeroes[i]++;
                }
            }

            int maxScore = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                maxScore = Math.Max(maxScore, suffixZeroes[i] + suffixOnes[s.Length - 1] - suffixOnes[i]);
            }

            return maxScore;
        }
    }
}
