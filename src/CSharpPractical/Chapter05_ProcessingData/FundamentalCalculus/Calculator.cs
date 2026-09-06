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

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter05_ProcessingData.FundamentalCalculus
{
    public class Calculator
    {
        public int Add(int left, int right)
        {
            // Example
            return left + right;
        }

        public int Subtract(int left, int right)
        {
            // TODO: Return the difference
            return 0;
        }

        public int Multiply(int left, int right)
        {
            // TODO: Return the product
            return 0;
        }

        public int Divide(int left, int right)
        {
            // TODO: Return the whole divident
            return 0;
        }

        public int Modulo(int left, int right)
        {
            // TODO: Return the modulo
            return 0;
        }

        public int AbsoluteValue(int value)
        {
            // TODO: Return the absolute value
            return 0;
        }

        public int Square(int value)
        {
            // TODO: Return the squared value
            return 0;
        }

        public int Inverse(int value)
        {
            // TODO: Return the inverse value
            // -3 => 3
            // 3 => -3
            return 0;
        }
    }
}
