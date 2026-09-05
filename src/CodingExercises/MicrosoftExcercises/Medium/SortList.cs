/*
 =======================================================================================
 CHALLENGE: SortList
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SortList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SortListTests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class SortList
    {
        public class Solution
        {
            public ListNode SortList(ListNode head)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

            private ListNode Merge(ListNode left, ListNode right)
            {
                var dummy = new ListNode();
                var p1 = left;
                var p2 = right;
                var current = dummy;

                while (p1 != null && p2 != null)
                {
                    if (p1.val < p2.val)
                    {
                        current.next = p1;

                        p1 = p1.next;
                    }
                    else
                    {
                        current.next = p2;

                        p2 = p2.next;
                    }

                    current = current.next;
                }

                if (p1 != null)
                {
                    current.next = p1;
                }

                if (p2 != null)
                {
                    current.next = p2;
                }

                return dummy.next;
            }

            private ListNode GetMid(ListNode head)
            {
                ListNode slow = null;
                var fast = head;

                while (fast != null && fast.next != null)
                {
                    slow = slow == null ? fast : slow.next;
                    fast = fast.next.next;
                }

                var mid = slow.next;

                slow.next = null;

                return mid;
            }
        }
    }
}
