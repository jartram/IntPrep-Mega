/*
 =======================================================================================
 CHALLENGE: MinWindowSubstring
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MinWindowSubstring problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MinWindowSubstringTests
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class MinWindowSubstring
    {
        //FIRST APPROACH (MINE)
        public string MinWindow(string str, string t)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool ContainsAllLetter(Dictionary<char, int> freqT, Dictionary<char, int> freqCurrent)
        {
            foreach (var key in freqT.Keys)
            {
                if (!freqCurrent.ContainsKey(key) || freqT[key] > freqCurrent[key])
                {
                    return false;
                }
            }
            return true;
        }

        private Dictionary<char, int> CreateFrequencyDictionary(string str)
        {
            var dict = new Dictionary<char, int>();

            foreach (var c in str)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 0);
                }

                dict[c]++;
            }

            return dict;
        }

        //optimized

        public string MinWindowOPTIMIZED(string str, string t)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
