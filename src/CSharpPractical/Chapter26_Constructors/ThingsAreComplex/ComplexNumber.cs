/*
 =======================================================================================
 CHALLENGE: Things Are Complex (26-constructors)
 CHAPTER: Chapter26_Constructors
 
 DESCRIPTION:
 Implement a ComplexNumber class with Real() and Imaginary() methods, addition, subtraction,
 multiplication, division, magnitude, reciprocal, and string representation.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter26_Constructors.ThingsAreComplex.UnitTestComplexNumber
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter26_Constructors.ThingsAreComplex;

public class ComplexNumber
{
    private double real = 0;
    private double imaginary = 0;

    public ComplexNumber()
    {
    }

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public double Real()
    {
        // TODO: Return real component
        return real;
    }

    public double Imaginary()
    {
        // TODO: Return imaginary component
        return imaginary;
    }

    public double Magnitude()
    {
        // TODO: Calculate and return magnitude sqrt(real^2 + imag^2)
        throw new NotImplementedException();
    }

    public ComplexNumber Add(ComplexNumber value)
    {
        // TODO: Add complex number
        throw new NotImplementedException();
    }

    public ComplexNumber Subtract(ComplexNumber value)
    {
        // TODO: Subtract complex number
        throw new NotImplementedException();
    }

    public ComplexNumber Multiply(ComplexNumber value)
    {
        // TODO: Multiply complex number
        throw new NotImplementedException();
    }

    public ComplexNumber Divide(ComplexNumber value)
    {
        // TODO: Divide complex number
        throw new NotImplementedException();
    }

    public ComplexNumber Reciprocal()
    {
        // TODO: Return reciprocal 1 / z
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        // TODO: Return string representation
        throw new NotImplementedException();
    }
}
