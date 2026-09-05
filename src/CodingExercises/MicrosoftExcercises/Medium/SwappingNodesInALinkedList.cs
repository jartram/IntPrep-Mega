/*
 =======================================================================================
 CHALLENGE: SwappingNodesInALinkedList
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SwappingNodesInALinkedList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SwappingNodesInALinkedListTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class SwappingNodesInALinkedList
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            if (head == null)
            {
                return head;
            }

            var index = 1;
            var fast = head;

            while (index < k)
            {
                fast = fast.next;
                index++;
            }

            var firstSwap = fast;
            fast = fast.next;
            var slow = head;

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            var aux = slow.val;
            slow.val = firstSwap.val;
            firstSwap.val = aux;

            return head;
        }
    }
}
