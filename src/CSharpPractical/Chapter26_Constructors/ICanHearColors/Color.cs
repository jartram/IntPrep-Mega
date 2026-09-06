/*
 =======================================================================================
 CHALLENGE: I Can Hear Colors (26-constructors)
 CHAPTER: Chapter26_Constructors
 
 DESCRIPTION:
 Refactor the Color class with Red, Green, and Blue byte properties (0-255)
 and full 3-argument constructor.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter26_Constructors.ICanHearColors.UnitTestColor
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter26_Constructors.ICanHearColors;

public class Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    public Color() : this(0, 0, 0)
    {
    }

    public Color(int red, int green, int blue)
    {
        Red = Math.Clamp(red, 0, 255);
        Green = Math.Clamp(green, 0, 255);
        Blue = Math.Clamp(blue, 0, 255);
    }

    public void SetRed(int r) => Red = Math.Clamp(r, 0, 255);
    public void SetGreen(int g) => Green = Math.Clamp(g, 0, 255);
    public void SetBlue(int b) => Blue = Math.Clamp(b, 0, 255);
}
