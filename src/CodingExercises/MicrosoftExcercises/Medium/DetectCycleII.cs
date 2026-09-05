/*
 =======================================================================================
 CHALLENGE: DetectCycleII
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DetectCycleII problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.DetectCycleIITests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class DetectCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            var fast = head;
            var slow = head;

            do
            {
                fast = fast?.next?.next;
                slow = slow?.next;
            } while (fast != null && fast?.next != null && fast != slow);


            if (fast == null || fast?.next == null)
            {
                return null;
            }

            slow = head;

            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return fast;
        }
    }
}
