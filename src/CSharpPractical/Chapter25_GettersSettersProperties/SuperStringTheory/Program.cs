/*
 =======================================================================================
 CHALLENGE: SuperStringTheory (25-getters-setters-properties)
 CHAPTER: Chapter25_GettersSettersProperties
 
 DESCRIPTION:
 * # Super String Theory
 *
 * `SuperString` class is a class that provides a new empowered `String` class with extra functionality. Internally it makes use of a regular `String` object, which is made available via the getter `GetText()` and can be altered via the setter `SetText()`.
 *
 * Start this challenge by replacing the getter and setter with a property called `Text`. Make sure to use a property with a backing attribute. You can remove the getter and setter methods. The setter property should add a safe-guard and check if the incoming object is `null`. If so, the internal `text` object should be replaced with an empty string `""` instead of `null`.
 *
 * Next you can add the following functionality:
 *
 * * `Append(string text)`: appends a piece of text at the back of the original text
 * * `Prepend(string text)`: prepends a piece of text at the front of the original text
 * * `IsValidNumber(): bool`: return `true` if the internal text only contains valid digits, in other words only characters between `0` and `9`. `+` and `-` symbols are also considered invalid.
 * * `TrimStart()`: remove spaces at the beginning of the text. So `  Hello World` should become `Hello World`.
 * * `TrimEnd()`: remove spaces at the end of the text. So `Hello World    ` should become `Hello World`. You will need to add this method yourself. Make sure to follow the naming convention.
 * * `Trim()`: remove spaces at the start and end of the text. So `      Hello World    ` should become `Hello World`. You will need to add this method yourself. Make sure to follow the naming convention.
 *
 * Implement all this functionality without making use of the functionality provided by the `String` class itself.
 *
 * Also make sure that this functionality works with empty strings `""`.
 *
 * The `Main()` method already provides a partial demo application. You will also need to refactor this to take the new `Text` property into account instead of the getter and setter. Feel free to extend the application to take the whole implementation of `SuperString` into account.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Super String Theory
 *
 * Lets append the word " World" to "Hello"
 *  > Before: Hello
 *  > After: Hello World
 *
 * Let's check some numbers ...
 * Is 1234 a valid number? True
 * Is SDFNBDSF a valid number? False
 * Is #88 a valid number? False
 *
 * OK, now for some trimming ...
 * If we trim at the beginning "  Hello There!", then we get "Hello There!"
 * If we trim at the beginning "There is no place like home!    ", then we get "There is no place like home!    "
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter25_GettersSettersProperties.SuperStringTheory.UnitTestSuperString
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter25_GettersSettersProperties.SuperStringTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Super String Theory\n");

            // Append
            Console.WriteLine("Lets append the word \" World\" to \"Hello\"");
            SuperString hello = new SuperString();

            hello.SetText("Hello");
            Console.WriteLine(" > Before: " + hello.GetText());

            hello.Append(" World");
            Console.WriteLine(" > After: " + hello.GetText());

            // IsValidNumber
            Console.WriteLine("\nLet's check some numbers ...");
            SuperString number = new SuperString();

            number.SetText("1234");
            Console.WriteLine($"Is {number.GetText()} a valid number? " + number.IsValidNumber());

            number.SetText("SDFNBDSF");
            Console.WriteLine($"Is {number.GetText()} a valid number? " + number.IsValidNumber());

            number.SetText("#88");
            Console.WriteLine($"Is {number.GetText()} a valid number? " + number.IsValidNumber());

            // Trim
            Console.WriteLine("\nOK, now for some trimming ...");
            SuperString text = new SuperString();

            text.SetText("  Hello There!");
            Console.Write($"If we trim at the beginning \"{text.GetText()}\"");
            text.TrimStart();
            Console.WriteLine($", then we get \"{text.GetText()}\"");

            text.SetText("There is no place like home!    ");
            Console.Write($"If we trim at the beginning \"{text.GetText()}\"");
            text.TrimStart();
            Console.WriteLine($", then we get \"{text.GetText()}\"");
        }
    }
}
