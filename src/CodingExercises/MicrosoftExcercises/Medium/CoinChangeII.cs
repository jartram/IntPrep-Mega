/*
 =======================================================================================
 CHALLENGE: CoinChangeII
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the CoinChangeII problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.CoinChangeIITests
 =======================================================================================
*/

﻿using System;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class CoinChangeII
    {
        public int Change(int amount, int[] coins)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int ChangeReview(int amount, int[] coins)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int Change2(int amount, int[] coins)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int DFS(int[] coins, int amount, int index, int?[,] cache)
        {
            if (amount == 0)
            {
                return 1;
            }

            if (index == coins.Length)
            {
                return 0;
            }

            if (cache[index, amount] != null)
            {
                return cache[index, amount].Value;
            }

            var total = 0;

            for (int i = index; i < coins.Length; i++)
            {
                if (amount < coins[i])
                {
                    break;
                }

                var times = 1;

                while (times * coins[i] <= amount)
                {
                    total += DFS(coins, amount - times * coins[i], i + 1, cache);
                    times++;
                }
            }

            cache[index, amount] = total;

            return total;
        }
    }
}
