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

namespace CSharpPractical.Chapter26_Constructors.BackToTheFuture
{
    public class TimeStamp
    {
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;

        public TimeStamp()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        public TimeStamp(int h, int m, int s)
        {
            if (h < 0 || m < 0 || s < 0)
            {
                hours = 0;
                minutes = 0;
                seconds = 0;
                return;
            }

            int total = h * 3600 + m * 60 + s;
            total %= (24 * 3600);
            hours = total / 3600;
            minutes = (total % 3600) / 60;
            seconds = total % 60;
        }

        public int Hours
        {
            get => hours;
            set
            {
                if (value < 0) hours = 0;
                else hours = value % 24;
            }
        }

        public int Minutes
        {
            get => minutes;
            set
            {
                if (value < 0) minutes = 0;
                else minutes = value % 60;
            }
        }

        public int Seconds
        {
            get => seconds;
            set
            {
                if (value < 0) seconds = 0;
                else seconds = value % 60;
            }
        }

        public void AddSeconds(int delta)
        {
            if (delta < 0) return;
            int total = hours * 3600 + minutes * 60 + seconds + delta;
            total %= (24 * 3600);
            hours = total / 3600;
            minutes = (total % 3600) / 60;
            seconds = total % 60;
        }

        public void AddMinutes(int delta)
        {
            if (delta < 0) return;
            int total = hours * 60 + minutes + delta;
            total %= (24 * 60);
            hours = total / 60;
            minutes = total % 60;
        }

        public void AddHours(int delta)
        {
            if (delta < 0) return;
            hours = (hours + delta) % 24;
        }
    }
}
