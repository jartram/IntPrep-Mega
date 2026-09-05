/*
 =======================================================================================
 CHALLENGE: RemoveElementsFromList
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RemoveElementsFromList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RemoveElementsFromListTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class RemoveElementsFromList
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var actual = head;
            var dummy = new ListNode(0, head);
            var prev = dummy;

            while (actual != null)
            {
                if (actual.val == val)
                {
                    prev.next = actual.next;
                }
                else
                {
                    prev = actual;
                }

                actual = actual.next;
            }

            return dummy.next;
        }
    }
}
