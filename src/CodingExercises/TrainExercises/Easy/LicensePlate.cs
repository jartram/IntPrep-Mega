/*
 =======================================================================================
 CHALLENGE: LicensePlate
 CATEGORY: TrainExercises / Easy
 SOURCE: https://leetcode.com/problems/shortest-completing-word
 
 DESCRIPTION:
 Solve the LicensePlate problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.TrainExercises.LicensePlateTests
 =======================================================================================
*/

using System;
using System.Linq;

namespace CodingExercises.TrainExercises.Easy
{
    public class LicensePlate
    {
        //https://leetcode.com/problems/shortest-completing-word
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            words = words.OrderBy(x => x.Length).ToArray();
            var wordLength = 0;
            int[] bucketLicense = new int[26];

            foreach (var character in licensePlate)
            {
                if (char.IsLetter(character))
                {
                    bucketLicense[char.ToLower(character) - 'a']++;
                    wordLength++;
                }
            }

            foreach (var word in words)
            {
                var coincidences = 0;
                int[] bucketWord = new int[26];

                foreach (var character in word)
                {
                    bucketWord[char.ToLower(character) - 'a']++;
                }

                for (int i = 0; i < bucketWord.Length; i++)
                {
                    if (bucketLicense[i] > 0 && bucketWord[i] > 0)
                    {
                        coincidences += Math.Min(bucketWord[i], bucketLicense[i]);
                    }

                    if (coincidences >= wordLength)
                    {
                        return word;
                    }
                }
            }


            return "";
        }
    }
}
