using CodingExercises.Solutions.Shared;
using CodingExercises.Solutions.CommonExercises;

namespace CodingExercises.Solutions.MicrosoftExcercises.Easy
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
