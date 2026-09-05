/*
 =======================================================================================
 CHALLENGE: SumTwoNumbers
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SumTwoNumbers problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.SumTwoNumbersTests
 =======================================================================================
*/

﻿using System.Collections.Generic;

namespace CodingExercises.Exercises
{
    public class SumTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private Queue<int> GetQueue(ListNode list)
        {
            var queue = new Queue<int>();
            var aux = list;

            while (aux != null)
            {
                queue.Enqueue(aux.val);
                aux = aux.next;
            }

            return queue;
        }

        public ListNode AddTwoNumbersOptimized(ListNode l1, ListNode l2)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public ListNode AddTwoNumbersRevisited(ListNode l1, ListNode l2)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
