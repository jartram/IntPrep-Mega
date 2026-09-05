/*
 =======================================================================================
 CHALLENGE: BuyAndSellStocks
 CATEGORY: CommonExercises / Easy-DynamicProgramming
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BuyAndSellStocks problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.BuyAndSellStocksTests
 =======================================================================================
*/

using System;

namespace CodingExercises.CommonExercises.Easy_DynamicProgramming
{
    public class BuyAndSellStocks
    {
        public int MaxProfit(int[] prices)
        {
            var profits = new int[prices.Length + 1];
            var max = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                profits[i] = Math.Max(0, profits[i - 1] + (prices[i] - prices[i - 1]));
                max = Math.Max(profits[i], max);
            }

            return max;
        }
    }
}
