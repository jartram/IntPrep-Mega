/*
 =======================================================================================
 CHALLENGE: DecodeWays
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DecodeWays problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.DecodeWaysTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class DecodeWays
    {
        public int NumDecodings(string s)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private int NumDecodings(string s, int start, Dictionary<int, int> cache)
        {
            if (start == s.Length)
            {
                return 1;
            }

            if (cache.ContainsKey(start))
            {
                return cache[start];
            }

            var count = 0;

            for (int i = 1; i <= 2 && i + start <= s.Length; i++)
            {
                var actual = int.Parse(s.Substring(start, i));

                if (actual == 0 || actual > 26)
                {
                    break;
                }

                count += NumDecodings(s, i + start, cache);
            }

            cache[start] = count;

            return count;
        }
    }
}
