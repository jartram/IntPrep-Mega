/*
 =======================================================================================
 CHALLENGE: Generator-of-numbers (28-interfaces)
 CHAPTER: Chapter28_Interfaces
 
 DESCRIPTION:
 * # Generator of Numbers
 *
 * In this application we will be building different classes that can generate a series of numbers. These generators can then be used for different purposes. One of their purposes can be to mathematically calculate their finite sequence sum.
 *
 * Declare the interface `IGenerator` with the following methods:
 *
 * * `Next(): int`, which generates the next number in the series
 * * `Reset(): void`, which restarts the generator back at the start of the number series
 *
 * Provide the following generators by implementing the `IGenerator` interface.
 *
 * * `NaturalGenerator`: which generates the sequential natural numbers series `0, 1, 2, 3, 4, 5, 6, ...`.
 * * `PowersOfTwoGenerator`: which generates the powers of two series: `1, 2, 4, 8, 16, 32, ...`.
 * * `FibonacciGenerator`: which generates the Fibonacci number sequence `1, 1, 2, 3, 5, 8, ....`.
 * * `RandomGenerator`: which generates random numbers.
 *
 * Uncomment the code blocks in `Main()` to test your code.
 *
 * ## Expected Output
 *
 * ```text
 * Welcome to Generator of Numbers.
 *
 * Series of natural numbers:
 * 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 
 *
 * Powers of two:
 * 1 2 4 8 16 32 64 128 256 512 1024 2048 4096 8192 16384 32768 65536 131072 262144 524288 
 *
 * Fibonacci Sequence:
 * 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765 
 *
 * Random series of numbers:
 * 216531900 559744717 61319931 1895015772 1748002307 1376320670 816555471 16899801 1723357923 1406595917 52391889 1965329923 951872917 1630943778 603558904 830393156 550558735 376498629 1573947065 892455993 
 * 216531900 559744717 61319931 1895015772 1748002307 1376320670 816555471 16899801 1723357923 1406595917 52391889 1965329923 951872917 1630943778 603558904 830393156 550558735 376498629 1573947065 892455993
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter28_Interfaces.GeneratorOfNumbersTest
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter28_Interfaces.Generator_of_numbers
{
    public interface IGenerator
    {
        int Next();
        void Reset();
    }

    public class NaturalGenerator : IGenerator
    {
        // TODO: Implement NaturalGenerator
        public int Next() => 0;
        public void Reset() {}
    }

    public class PowersOfTwoGenerator : IGenerator
    {
        // TODO: Implement PowersOfTwoGenerator
        public int Next() => 0;
        public void Reset() {}
    }

    public class FibonacciGenerator : IGenerator
    {
        // TODO: Implement FibonacciGenerator
        public int Next() => 0;
        public void Reset() {}
    }

    public class RandomGenerator : IGenerator
    {
        // TODO: Implement RandomGenerator
        public int Next() => 0;
        public void Reset() {}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generator of Numbers.");
            Console.WriteLine();
            
            // Console.WriteLine("Series of natural numbers:");
            // IGenerator natural = new NaturalGenerator();
            // for(int i = 0; i < 20; i++) {
            //   Console.Write(natural.Next() + " ");
            // }

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Powers of two:");
            // IGenerator powersOfTwo = new PowersOfTwoGenerator();
            // for(int i = 0; i < 20; i++) {
            //   Console.Write(powersOfTwo.Next() + " ");
            // }

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Fibonacci Sequence:");
            // IGenerator fibonacci = new FibonacciGenerator();
            // for(int i = 0; i < 20; i++) {
            //   Console.Write(fibonacci.Next() + " ");
            // }

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine("Random series of numbers:");
            // IGenerator random = new RandomGenerator();
            // for(int i = 0; i < 20; i++) {
            //   Console.Write(random.Next() + " ");
            // }
            // random.Reset();
            // Console.WriteLine();
            // for(int i = 0; i < 20; i++) {
            //   Console.Write(random.Next() + " ");
            // }
        }
    }
}
