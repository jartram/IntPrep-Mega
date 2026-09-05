/*
 =======================================================================================
 CHALLENGE: ReverseKNodes
 CATEGORY: MicrosoftExcercises / Hard
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ReverseKNodes problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.ReverseKNodesTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Hard
{
    public class ReverseKNodes
    {
        public ListNode Solve(ListNode head, int k)
        {
            if (k < 1)
            {
                return head;
            }
            var fast = head;
            var slow = head;

            ListNode dummy = new ListNode(0);
            ListNode lastGroup = dummy;

            while (fast != null)
            {
                int i = 1;
                // This runner verifies if there is K remaining nodes
                while (fast != null && i <= k)
                {
                    fast = fast.next;
                    i++;
                }

                if (i - 1 == k) // If there are K node remaining 
                {
                    i = 0;
                    var first = slow;
                    ListNode prev = null;
                    while (i < k)
                    {
                        var tmp = slow.next;

                        slow.next = prev;
                        prev = slow;

                        slow = tmp;
                        i++;
                    }

                    lastGroup.next = prev;
                    lastGroup = first;
                }
                else //  If there are K node remaining 
                {
                    lastGroup.next = slow;
                }
            }

            return dummy.next;
        }
    }
}
