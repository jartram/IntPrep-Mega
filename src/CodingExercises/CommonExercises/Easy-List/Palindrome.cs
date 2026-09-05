/*
 =======================================================================================
 CHALLENGE: Palindrome
 CATEGORY: CommonExercises / Easy-List
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Palindrome problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.PalindromeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.CommonExercises.Easy_List
{
    public class Palindrome
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

                //reversing left side of the list
                var tmp = slow.next;
                slow.next = prev;
                prev = slow;
                slow = tmp;
            }

            if (fast != null) //odd
            {
                slow = slow.next;
            }

            while (slow != null)
            {
                if (slow.val != prev.val)
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
