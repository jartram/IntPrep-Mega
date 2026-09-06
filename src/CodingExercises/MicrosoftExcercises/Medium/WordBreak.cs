/*
 =======================================================================================
 CHALLENGE: WordBreakEx
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the WordBreakEx problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.WordBreakTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class WordBreakEx
    {

        public Dictionary<string, bool> Cache = new Dictionary<string, bool>();
        public HashSet<string> wordSet;

        public bool WordBreak(string str, IList<string> words)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool WordBreak(string str)
        {
            if (wordSet.Contains(str))
            {
                return true;
            }

            if (Cache.ContainsKey(str))
            {
                return Cache[str];
            }

            for (int i = 1; i <= str.Length; i++)
            {
                var left = str.Substring(0, i);

                if (wordSet.Contains(left) && WordBreak(str.Substring(i)))
                {
                    Cache.Add(str, true);

                    return true;
                }
            }

            Cache.Add(str, false);

            return false;
        }
    }

    public class FirstApproachTLE
    {
        public Dictionary<string, int> dict = new Dictionary<string, int>();
        public bool result = false;

        public bool WordBreak(string str, IList<string> words)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Backtrack(string str, int index, string currentWord)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
