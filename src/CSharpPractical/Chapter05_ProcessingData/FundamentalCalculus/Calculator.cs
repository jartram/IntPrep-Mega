/*
 =======================================================================================
 CHALLENGE: FundamentalCalculus (05-processing-data)
 CHAPTER: Chapter05_ProcessingData
 
 DESCRIPTION:
 * # Fundamental Calculus
 *
 * This app models a basic calculator. Implement all the methods of the `Calculator` class so they return the correct values.
 *
 * The `Add()` method has already been implemented to provide you with an example.
 *
 * You can also extend the `Main()` with more code to test your implementation.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.FundamentalCalculus.UnitTestCalculator
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter05_ProcessingData.FundamentalCalculus
{
    public class Calculator
    {
        public int Add(int left, int right) => left + right;
        public int Subtract(int left, int right) => left - right;
        public int Multiply(int left, int right) => left * right;
        public int Divide(int left, int right) => left / right;
        public int Modulo(int left, int right) => left % right;
        public int AbsoluteValue(int value) => Math.Abs(value);
        public int Square(int value) => value * value;
        public int Inverse(int value) => -value;
    }
}
