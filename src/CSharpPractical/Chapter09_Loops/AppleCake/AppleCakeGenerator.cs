/*
 =======================================================================================
 CHALLENGE: AppleCake (09-loops)
 CHAPTER: Chapter09_Loops
 
 DESCRIPTION:
 * # AppleCake
 *
 * AppleCake is a kind of word-game for children. The purpose is to iterate the list of natural numbers, incrementing the number each round. If the number is dividable by `3`, you shout `apple`, or `cake` if it is dividable by `5`. In case the number is dividable by both `3` and `5`, you shout `applecake`.
 *
 * This application generates an overview of the natural numbers and their labels. However some functionality still needs to be implemented.
 *
 * Your task (also see `View => Task List` in Visual Studio):
 *
 * * Implement the method `AppleCake()` in the class `AppleCakeGenerator` so it returns the correct string for a given `value`, namely `apple`, `cake` or `applecake`.
 * * Implement the method `Generate()` in the class `AppleCakeGenerator` so it iterates all the numbers from `start` to `end` (inclusive). Call the method `string text = AppleCake(i)` on each iteration and add the result to the `output` string.
 *
 * ## Expected output
 *
 * ```text
 * Welcome to the AppleCake generator
 * 3: apple
 * 5: cake
 * 6: apple
 * 9: apple
 * 10: cake
 * 12: apple
 * 15: applecake
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter09_Loops.AppleCake.UnitTestsAppleCakeGenerator
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter09_Loops.AppleCake
{
    public class AppleCakeGenerator
    {
        public string AppleCake(int value)
        {
            string text = "";

            // TODO Assign the correct string according to value
            // If value is dividable by 3, text should be "apple"
            // If value is dividable by 5, text should be "cake"
            // If value is dividable by 3 and 5, text should be "applecake"
            // In all other cases the string should be left empty

            return text;
        }

        public string Generate(int start, int end)
        {
            string output = "";

            // TODO Create a loop that iterates over all the numbers from start to end
            // Add the output of AppleCake(i) to the output string in each iteration
            // in the following format (also see README.md for expected output)
            // 3: apple
            //
            // If its an empty result, then don't add it to the output

            // Place the following in the body of your loop and replace the 3
            // with your iterator (i for example).
            string text = AppleCake(3);

            return output;
        }
    }
}
