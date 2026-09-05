/*
 =======================================================================================
 CHALLENGE: InterleavingString
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the InterleavingString problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.InterleavingStringTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class InterleavingString
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }
            var cache = new Dictionary<string, bool>();

            return IsInterleave(s1, s2, s3, 0, 0, 0, cache);
        }
        private bool IsInterleave(string s1, string s2, string s3, int i1, int i2, int i3, Dictionary<string, bool> cache)
        {
            var key = $"{i1}${i2}${i3}";
            if (i3 == s3.Length)
            {
                return true;
            }
            if (cache.ContainsKey(key))
            {
                return cache[key];
            }
            bool result = false;
            if (!((i1 < s1.Length && s1[i1] == s3[i3]) || (i2 < s2.Length && s2[i2] == s3[i3])))
            {
                return false;
            }
            if (i1 < s1.Length && s1[i1] == s3[i3])
            {
                result = IsInterleave(s1, s2, s3, i1 + 1, i2, i3 + 1, cache);
            }
            if (i2 < s2.Length && s2[i2] == s3[i3])
            {
                result = result || IsInterleave(s1, s2, s3, i1, i2 + 1, i3 + 1, cache);
            }
            cache.Add(key, result);
            return result;
        }
    }
}
