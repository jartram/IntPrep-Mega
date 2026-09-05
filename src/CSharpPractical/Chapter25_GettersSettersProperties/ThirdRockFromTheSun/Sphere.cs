/*
 =======================================================================================
 CHALLENGE: Third Rock from the Sun (25-getters-setters-properties)
 CHAPTER: Chapter25_GettersSettersProperties
 
 DESCRIPTION:
 Implement a Sphere class with Radius and Diameter properties, and methods to calculate
 Surface and Volume.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter25_GettersSettersProperties.ThirdRockFromTheSun.UnitTestSphere
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter25_GettersSettersProperties.ThirdRockFromTheSun
{
    public class Sphere
    {
        private double radius = 0;

        public double Radius
        {
            get => radius;
            set => radius = Math.Abs(value);
        }

        public double Diameter
        {
            get => radius * 2;
            set => radius = Math.Abs(value) / 2;
        }

        public double Surface() => 4 * Math.PI * radius * radius;
        public double Volume() => (4.0 / 3.0) * Math.PI * radius * radius * radius;
    }
}
