/*
 =======================================================================================
 CHALLENGE: RemoveNTHElement
 CATEGORY: CommonExercises / Easy-List
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RemoveNTHElement problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.RemoveNTHElementTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.CommonExercises.Easy_List
{
    public class RemoveNTHElement
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            ListNode first = dummy;
            ListNode second = dummy;

            dummy.next = head;

            for (int i = 1; i <= n + 1; i++)
            {
                first = first.next;
            }
            
            while (first != null)
            {
                first = first.next;
                second = second.next;
            }
            
            second.next = second.next.next;
            
            return dummy.next;
        }
    }
}
