/*
 =======================================================================================
 CHALLENGE: GroupAnagramsSolved
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the GroupAnagramsSolved problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.GroupAnagramsSolvedTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.Exercises
{
    public class GroupAnagramsSolved
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private bool IsAnagram(int[] bucket1, int[] bucket2)
        {
            for (int i = 0; i < bucket1.Length; i++)
            {
                if (bucket1[i] != bucket2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
