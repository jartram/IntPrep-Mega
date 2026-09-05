/*
 =======================================================================================
 CHALLENGE: ReverseList
 CATEGORY: CommonExercises / Easy-List
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ReverseList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.ReverseListTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.CommonExercises.Easy_List
{
    public class ReverseList
    {
        public ListNode Solution(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            else
            {
                var actual = Solution(head.next);
                head.next.next = head;
                head.next = null;

                return actual;
            }
        }

        public ListNode ReverseListTwoPointers(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var slow = head;
            ListNode prev = null;

            while (slow != null)
            {
                var tmp = slow.next;
                slow.next = prev;
                prev = slow;
                slow = tmp;
            }

            return prev;
        }
    }
}
