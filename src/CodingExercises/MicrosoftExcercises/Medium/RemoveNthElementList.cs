/*
 =======================================================================================
 CHALLENGE: RemoveNthElementList
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RemoveNthElementList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RemoveNthElementListTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class RemoveNthElementList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var slow = head;
            var fast = head;
            ListNode prev = null;

            for (int i = 0; i < n; i++)
            {
                fast = fast?.next;
            }

            while (fast != null)
            {
                prev = slow;
                slow = slow?.next;
                fast = fast?.next;
            }

            if (prev != null)
            {
                prev.next = slow.next;
                return head;
            }
            else
            {
                return slow?.next;
            }
        }
    }
}
