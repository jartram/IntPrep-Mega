/*
 =======================================================================================
 CHALLENGE: Things Are Complex (26-constructors)
 CHAPTER: Chapter26_Constructors
 
 DESCRIPTION:
 Implement a ComplexNumber class with Real() and Imaginary() methods, addition, subtraction,
 multiplication, division, magnitude, reciprocal, and string representation.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter26_Constructors.ThingsAreComplex.UnitTestComplexNumber
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter26_Constructors.ThingsAreComplex
{
    public class ComplexNumber
    {
        private double real = 0;
        private double imaginary = 0;

        public ComplexNumber()
        {
            real = 0;
            imaginary = 0;
        }

        public ComplexNumber(double r, double i)
        {
            real = r;
            imaginary = i;
        }

        public double Real() => real;
        public double Imaginary() => imaginary;
        public double Magnitude() => Math.Sqrt(real * real + imaginary * imaginary);

        public ComplexNumber Add(ComplexNumber right)
        {
            return new ComplexNumber(real + right.real, imaginary + right.imaginary);
        }

        public ComplexNumber Subtract(ComplexNumber right)
        {
            return new ComplexNumber(real - right.real, imaginary - right.imaginary);
        }

        public ComplexNumber Multiply(ComplexNumber right)
        {
            return new ComplexNumber(
                real * right.real - imaginary * right.imaginary,
                real * right.imaginary + imaginary * right.real
            );
        }

        public ComplexNumber Divide(ComplexNumber right)
        {
            double denom = right.real * right.real + right.imaginary * right.imaginary;
            return new ComplexNumber(
                (real * right.real + imaginary * right.imaginary) / denom,
                (imaginary * right.real - real * right.imaginary) / denom
            );
        }

        public override string ToString()
        {
            string sign = imaginary >= 0 ? "+" : "-";
            return $"({real} {sign} {Math.Abs(imaginary)}i)";
        }
    }
}
