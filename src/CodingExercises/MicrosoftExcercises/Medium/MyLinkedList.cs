/*
 =======================================================================================
 CHALLENGE: MyLinkedList
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MyLinkedList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.MyLinkedListTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class MyLinkedList
    {

        private LinkedNode head;
        private int size;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            head = new LinkedNode(0, null);
            size = 0;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }

    public class LinkedNode
    {
        public LinkedNode next { get; set; }

        public int val { get; set; }

        public LinkedNode(int val, LinkedNode next)
        {
            this.val = val;
            this.next = next;
        }
    }


    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
