/*
 =======================================================================================
 CHALLENGE: WildCardMatch
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the WildCardMatch problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.WildCardMatchTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class WildCardMatch
    {
        public bool IsMatch(string str, string pattern)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool IsMatchAux(string str, string pattern, Dictionary<string, bool> cache)
        {
            if (cache.ContainsKey($"{str}#{pattern}"))
            {
                return cache[$"{str}#{pattern}"];
            }

            if (pattern == "*" || (pattern == "" && str == ""))
            {
                return true;
            }

            if (str.Length == 0 && pattern.Length > 0)
            {
                return false;
            }

            var patternIndex = 0;

            for (int i = 0; i < str.Length; i++)
            {
                var actual = str[i];

                var leftString = str.Substring(0, i + 1);
                var leftPattern = str.Substring(0, patternIndex + 1);

                if (patternIndex >= pattern.Length)
                {
                    cache.Add($"{leftString}#{leftPattern}", false);
                    return false;
                }

                if (actual == pattern[patternIndex] || pattern[patternIndex] == '?')
                {
                    patternIndex++;
                }
                else if (pattern[patternIndex] == '*')
                {
                    var chooseSolution = IsMatchAux(str.Substring(i + 1), pattern.Substring(patternIndex), cache);
                    var notChooseSolution = IsMatchAux(str.Substring(i), pattern.Substring(patternIndex + 1), cache);

                    cache.Add($"{leftString}#{leftPattern}", chooseSolution || notChooseSolution);

                    return chooseSolution || notChooseSolution;
                }
                else
                {
                    cache.Add($"{leftString}#{leftPattern}", false);
                    return false;
                }
            }

            return patternIndex == pattern.Length || (patternIndex == pattern.Length - 1 && pattern[patternIndex] == '*');
        }
    }
}
