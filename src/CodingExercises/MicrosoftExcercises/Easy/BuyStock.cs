/*
 =======================================================================================
 CHALLENGE: BuyStock
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BuyStock problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BuyStockTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class BuyStock
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                var diff = prices[i] - prices[i - 1];
                if (diff > 0)
                {
                    profit += diff;
                }
            }

            return profit;
        }
    }
}
