/*
 =======================================================================================
 CHALLENGE: SolveSortedListToBST
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the SolveSortedListToBST problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.SolveSortedListToBSTTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class SolveSortedListToBST
    {
        public TreeNode Solve(ListNode head)
        {
            var list = new List<ListNode>();

            var current = head;

            while (current != null)
            {
                list.Add(current);

                current = current.next;
            }

            var array = list.ToArray();

            var BST = CreateBST(array, 0, array.Length - 1);

            return BST;
        }

        public TreeNode CreateBST(ListNode[] array, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            var currentElement = left + (right - left) / 2;

            var newNode = new TreeNode(array[currentElement].val);

            newNode.left = CreateBST(array, left, currentElement - 1);
            newNode.right = CreateBST(array, currentElement + 1, right);

            return newNode;
        }
    }
}
