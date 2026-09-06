/*
 =======================================================================================
 CHALLENGE: ShoppingOffers
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ShoppingOffers problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.ShoppingOffersTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class ShoppingOffers
    {
        public Dictionary<string, int> memo;

        public int Solved(IList<int> price, IList<IList<int>> special, IList<int> needs)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int Shopping(int[] price, IList<int>[] special, int[] needs)
        {
            var needsKey = GetNeedsKey(needs);

            if (memo.ContainsKey(needsKey))
            {
                return memo[needsKey];
            }

            var totalCost = GetCost(price, needs);

            foreach (var offer in special)
            {
                int[] clone = new int[needs.Length];

                Array.Copy(needs, clone, needs.Length);

                int i;

                for (i = 0; i < clone.Length; i++)
                {
                    var diff = clone[i] - offer.ElementAt(i);

                    if (diff < 0)
                    {
                        break;
                    }

                    clone[i] = diff;
                }

                if (i == clone.Length)
                {
                    totalCost = Math.Min(totalCost, offer.ElementAt(i) + Shopping(price, special, clone));
                }
            }

            memo.Add(needsKey, totalCost);

            return totalCost;
        }

        public int GetCost(int[] price, int[] needs)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public string GetNeedsKey(int[] needs)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
