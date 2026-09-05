using CodingExercises.Solutions.Shared;
using CodingExercises.Solutions.CommonExercises;

namespace CodingExercises.Solutions.MicrosoftExcercises.Easy
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
