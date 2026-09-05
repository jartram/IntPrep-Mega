/*
 =======================================================================================
 CHALLENGE: PalindromeLinkedList
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PalindromeLinkedList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.PalindromeLinkedListTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return true;
            }

            var fast = head;
            var slow = head;
            ListNode prev = null;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;

                var tmp = slow.next;
                slow.next = prev;
                prev = slow;

                slow = tmp;
            }

            if (fast != null && fast.next == null)
            {
                slow = slow.next;
            }

            while (slow != null)
            {
                if (prev.val != slow.val)
                {
                    return false;
                }

                slow = slow.next;
                prev = prev.next;
            }

            return true;
        }
    }
}
