/*
 =======================================================================================
 CHALLENGE: BestTimetoBuyandSellStockII
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BestTimetoBuyandSellStockII problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BestTimetoBuyandSellStockIITests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class BestTimetoBuyandSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }

            return profit;
        }
    }
}
