/*
 =======================================================================================
 CHALLENGE: MeetingRoomsII
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MeetingRoomsII problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MeetingRoomsIITests
 =======================================================================================
*/

using System;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class MeetingRoomsII
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return 0;
            }

            int[] start = new int[intervals.Length];
            int[] end = new int[intervals.Length];

            for (int i = 0; i < intervals.Length; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            }

            Array.Sort(start);
            Array.Sort(end);

            int startPointer = 0, endPointer = 0;
            int usedRooms = 0;

            while (startPointer < intervals.Length)
            {

                if (start[startPointer] >= end[endPointer])
                {
                    usedRooms -= 1;
                    endPointer += 1;
                }

                usedRooms += 1;
                startPointer += 1;

            }

            return usedRooms;
        }
    }
}
