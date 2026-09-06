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

namespace CSharpPractical.Chapter25_GettersSettersProperties.SuperStringTheory;

public class SuperString
{
    private string text = "";

    public string Text
    {
        get => text;
        set => text = value ?? "";
    }

    public string GetText() => Text;
    public void SetText(string value) => Text = value;

    public void Append(string text)
    {
        // TODO: Append text to internal text
        throw new NotImplementedException();
    }

    public void Prepend(string text)
    {
        // TODO: Prepend text to internal text
        throw new NotImplementedException();
    }

    public bool IsValidNumber()
    {
        // TODO: Check if text contains only digits
        throw new NotImplementedException();
    }

    public void TrimStart()
    {
        // TODO: Remove leading spaces
        throw new NotImplementedException();
    }

    public void TrimEnd()
    {
        // TODO: Remove trailing spaces
        throw new NotImplementedException();
    }

    public void Trim()
    {
        // TODO: Remove leading and trailing spaces
        throw new NotImplementedException();
    }
}
