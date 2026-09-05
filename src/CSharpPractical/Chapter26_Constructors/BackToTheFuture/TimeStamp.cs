/*
 =======================================================================================
 CHALLENGE: Back to the Future (26-constructors)
 CHAPTER: Chapter26_Constructors
 
 DESCRIPTION:
 Implement a TimeStamp class with Hours, Minutes, and Seconds properties (normalized within 24h)
 and methods to add hours, minutes, and seconds.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter26_Constructors.BackToTheFuture.UnitTestTimeStamp
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter26_Constructors.BackToTheFuture;

public class TimeStamp
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public TimeStamp()
    {
        // TODO: Default constructor
    }

    public TimeStamp(int hours, int minutes, int seconds)
    {
        // TODO: Normalized time constructor
    }

    public void AddSeconds(int seconds)
    {
        // TODO: Add seconds and re-normalize
        throw new NotImplementedException();
    }

    public void AddMinutes(int minutes)
    {
        // TODO: Add minutes and re-normalize
        throw new NotImplementedException();
    }

    public void AddHours(int hours)
    {
        // TODO: Add hours and re-normalize
        throw new NotImplementedException();
    }
}
