/*
 =======================================================================================
 CHALLENGE: DeleteDuplicates
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DeleteDuplicates problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.DeleteDuplicatesTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class DeleteDuplicates
    {
        public ListNode Solve(ListNode head)
        {
            var actual = head;
            while (actual != null && actual.next != null)
            {
                if (actual.val == actual.next.val)
                {
                    actual.next = actual.next.next;
                }
                else
                {
                    actual = actual.next;
                }
            }
            return head;
        }
    }
}
