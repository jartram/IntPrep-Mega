using CodingExercises.Solutions.Shared;
using CodingExercises.Solutions.CommonExercises;

namespace CodingExercises.Solutions.MicrosoftExcercises.Easy
{
    public class DeleteNode
    {
        public void Solve(ListNode node)
        {
            var actual = node;
            ListNode prev = null;

            while (actual != null && actual.next != null)
            {
                actual.val = actual.next.val;

                prev = actual;
                actual = actual.next;
            }

            prev.next = null;
        }
    }
}
