/*
 =======================================================================================
 CHALLENGE: DesignHitCounter
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DesignHitCounter problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.DesignHitCounterTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class DesignHitCounter
    {
        public class HitCounter
        {

            private LinkedList<(int timestamp, int count)> hits;
            private int total;
            /** Initialize your data structure here. */
            public HitCounter()
            {
                hits = new LinkedList<(int timestamp, int count)>();
                total = 0;
            }

            /** Record a hit.
                @param timestamp - The current timestamp (in seconds granularity). */
            public void Hit(int timestamp)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            /** Return the number of hits in the past 5 minutes.
                @param timestamp - The current timestamp (in seconds granularity). */
            public int GetHits(int timestamp)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        }

    }
}
