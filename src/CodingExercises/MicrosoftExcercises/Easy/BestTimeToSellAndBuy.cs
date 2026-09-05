/*
 =======================================================================================
 CHALLENGE: BestTimeToSellAndBuy
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BestTimeToSellAndBuy problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BestTimeToSellAndBuyTests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class BestTimeToSellAndBuy
    {
        public int MaxProfit(int[] prices)
        {
            var profits = new int[prices.Length];
            var max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                profits[i] = Math.Max(profits[i - 1] + (prices[i] - prices[i - 1]), 0);
                max = Math.Max(profits[i], max);
            }
            return max;
        }
    }
}
