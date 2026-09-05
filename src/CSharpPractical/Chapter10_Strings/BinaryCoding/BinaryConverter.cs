/*
 =======================================================================================
 CHALLENGE: BinaryCoding (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # Binary Coding
 *
 * Binary Coding determines the decimal representation of a binary value.
 *
 * The class `BinaryConverter` has a method `ToDecimal()` that performs the conversion from a binary value to a decimal value. It just lacks some implementation.
 *
 * Your task (also see `View => Task List` in Visual Studio):
 *
 * * Implement the method `ToDecimal()` in the class `BinaryConverter` so it converts the `binary` string into a decimal value.
 * * Do note that the binary value can contain any number of spaces. These need to be ignored.
 * * The string can also start with a `b`character. This is typically required in programming languages such as C. You can ignore this starting character.
 *
 * ## Verwachte output
 *
 * ```text
 * Binary converter can convert a binary number to decimal.
 * Try it out. Just enter a binary value here:
 * b1000 1111
 * This equals 143
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.BinaryCoding.UnitTestBinaryConverter
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter10_Strings.BinaryCoding
{
    public class BinaryConverter
    {
        public int ToDecimal(string binary)
        {
            int decimalValue = 0;

            // TODO Convert the binary value in the variabel binary
            // to a decimal value
            //
            // Do note that it contain spaces, ignore these.
            //
            // It cal also start with a character 'b' which
            // should also be ignored.
            // Ex.: b1001 0101

            return decimalValue;
        }
    }
}
