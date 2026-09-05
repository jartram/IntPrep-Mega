/*
 =======================================================================================
 CHALLENGE: PartitionList
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PartitionList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.PartitionListTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            var dummyLesser = new ListNode();
            var dummyGreaterOrEqual = new ListNode();

            var currentLesser = dummyLesser;
            var currentGreaterOrEqual = dummyGreaterOrEqual;

            var current = head;

            while (current != null)
            {
                if (current.val < x)
                {
                    currentLesser.next = current;
                    currentLesser = currentLesser.next;
                }
                else
                {
                    currentGreaterOrEqual.next = current;
                    currentGreaterOrEqual = currentGreaterOrEqual.next;
                }

                current = current.next;
            }
            currentGreaterOrEqual.next = null;

            currentLesser.next = dummyGreaterOrEqual.next;

            return dummyLesser.next;
        }
    }
}
