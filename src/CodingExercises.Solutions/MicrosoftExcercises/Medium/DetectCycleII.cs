using CodingExercises.Solutions.Shared;
using CodingExercises.Solutions.CommonExercises;

namespace CodingExercises.Solutions.MicrosoftExcercises.Medium
{
    public class DetectCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            var fast = head;
            var slow = head;

            do
            {
                fast = fast?.next?.next;
                slow = slow?.next;
            } while (fast != null && fast?.next != null && fast != slow);


            if (fast == null || fast?.next == null)
            {
                return null;
            }

            slow = head;

            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return fast;
        }
    }
}
