/*
 =======================================================================================
 CHALLENGE: MinWindowString
 CATEGORY: CommonExercises / Hard-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MinWindowString problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.MinWindowStringTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.CommonExercises.Hard_Array
{
    public class MinWindowString
    {
        public string MinWindow(string s, string t)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool IsValid(string s, string t, Dictionary<char, int> freq, Dictionary<char, HashSet<int>> positions)
        {
            foreach (var tuple in freq)
            {
                if (positions.ContainsKey(tuple.Key))
                {
                    if (tuple.Value > positions[tuple.Key].Count)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
