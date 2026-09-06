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

namespace CSharpPractical.Chapter26_Constructors.ICanHearColors
{
    public class Color
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;

        public Color()
        {
            red = 0;
            green = 0;
            blue = 0;
        }

        public Color(int r, int g, int b)
        {
            Red = r;
            Green = g;
            Blue = b;
        }

        public int Red
        {
            get => red;
            set => red = Math.Clamp(value, 0, 255);
        }

        public int Green
        {
            get => green;
            set => green = Math.Clamp(value, 0, 255);
        }

        public int Blue
        {
            get => blue;
            set => blue = Math.Clamp(value, 0, 255);
        }

        public override string ToString() => $"Red: {Red} | Green: {Green} | Blue: {Blue}";
            public void SetRed(int v) => Red = v;
        public void SetGreen(int v) => Green = v;
        public void SetBlue(int v) => Blue = v;
}
}
