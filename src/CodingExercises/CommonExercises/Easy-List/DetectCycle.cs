/*
 =======================================================================================
 CHALLENGE: DetectCycle
 CATEGORY: CommonExercises / Easy-List
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DetectCycle problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.DetectCycleTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.CommonExercises.Easy_List
{
    public class DetectCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            var slow = head;
            ListNode fast = head.next;

            while (fast != null && fast.next != null)
            {
                if (fast == slow)
                {
                    return true;
                }

                slow = slow.next;
                fast = fast.next.next;
            }

            return false;
        }

        public ListNode DetectCycleII(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                {
                    break;
                }
            }

            if (fast == null || fast.next == null)
            {
                return null;
            }

            slow = head;

            while (fast != slow)
            {
                fast = fast.next;
                slow = slow.next;
            }

            return fast;
        }
    }
}
