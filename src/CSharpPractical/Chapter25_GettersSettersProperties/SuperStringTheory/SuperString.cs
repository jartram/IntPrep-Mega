/*
 =======================================================================================
 CHALLENGE: Super String Theory (25-getters-setters-properties)
 CHAPTER: Chapter25_GettersSettersProperties
 
 DESCRIPTION:
 Implement the SuperString class with Text property, Append, Prepend, IsValidNumber,
 TrimStart, TrimEnd, and Trim methods.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter25_GettersSettersProperties.SuperStringTheory.UnitTestSuperString
 =======================================================================================
*/

using System;
using System.Linq;

namespace CSharpPractical.Chapter25_GettersSettersProperties.SuperStringTheory
{
    public class SuperString
    {
        private string text = "";

        public string Text
        {
            get => text;
            set => text = value ?? "";
        }

        public void Append(string s) => Text = text + s;
        public void Prepend(string s) => Text = s + text;
        public bool IsValidNumber() => !string.IsNullOrWhiteSpace(text) && text.All(char.IsDigit);
        public void TrimStart() => Text = text.TrimStart();
        public void TrimEnd() => Text = text.TrimEnd();
        public void Trim() => Text = text.Trim();
    }
}
