/*
 =======================================================================================
 CHALLENGE: OddEvenListEx
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the OddEvenListEx problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.OddEvenListExTests
 =======================================================================================
*/

namespace CodingExercises.Exercises
{
    public class OddEvenListEx
    {
        public ListNode OddEvenList(ListNode head)
        {
            ListNode dummyLeft = new ListNode();
            ListNode dummyRight = new ListNode();

            ListNode currentLeft = dummyLeft;
            ListNode currentRight = dummyRight;
            ListNode current = head;
            var index = 1;

            while (current != null)
            {
                if (index % 2 != 0)
                {
                    currentLeft.next = new ListNode(current.val);
                    currentLeft = currentLeft.next;
                }
                else
                {
                    currentRight.next = new ListNode(current.val);
                    currentRight = currentRight.next;
                }

                current = current.next;
                index++;
            }
            currentLeft.next = dummyRight.next;

            return dummyLeft.next;
        }
    }
}
