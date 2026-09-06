/*
 =======================================================================================
 CHALLENGE: Third Rock from the Sun (25-getters-setters-properties)
 CHAPTER: Chapter25_GettersSettersProperties
 
 DESCRIPTION:
 Implement a Sphere class with Radius and Diameter properties, and methods to calculate
 Surface and Volume.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter25_GettersSettersProperties.ThirdRockFromTheSun.UnitTestSphere
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter25_GettersSettersProperties.ThirdRockFromTheSun;

public class Sphere
{
    public double Radius { get; set; }
    public double Diameter
    {
        get => Radius * 2;
        set => Radius = value / 2;
    }

    public double Surface()
    {
        // TODO: Return 4 * PI * r^2
        throw new NotImplementedException();
    }

    public double Volume()
    {
        // TODO: Return (4/3) * PI * r^3
        throw new NotImplementedException();
    }
}
