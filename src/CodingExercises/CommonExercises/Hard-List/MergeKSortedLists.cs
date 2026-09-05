/*
 =======================================================================================
 CHALLENGE: MergeKSortedLists
 CATEGORY: CommonExercises / Hard-List
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MergeKSortedLists problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.MergeKSortedListsTests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercises.CommonExercises.Hard_List
{
    public class MergeKSortedLists
    {
        //brute force approach
        public ListNode MergeKLists(ListNode[] lists)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public ListNode MergeKLists2(ListNode[] lists)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private ListNode MergeKLists2(ListNode[] lists, int left, int right)
        {
            if (left == right)
            {
                return lists[left];
            }

            if (left > right)
            {
                return null;
            }

            var mid = left + (right - left) / 2;
            var leftPartition = MergeKLists2(lists, left, mid);
            var rightPartition = MergeKLists2(lists, mid + 1, right);

            return Merge2(leftPartition, rightPartition);
        }

        private ListNode Merge2(ListNode left, ListNode right)
        {
            var dummy = new ListNode();
            var current = dummy;
            var p1 = left;
            var p2 = right;

            while (p1 != null && p2 != null)
            {
                if (p1.val <= p2.val)
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

            current.next = p1 ?? p2;

            return dummy.next;
        }
    }
}
