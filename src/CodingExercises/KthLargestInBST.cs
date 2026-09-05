/*
 =======================================================================================
 CHALLENGE: KthLargestInBST
 CATEGORY: General
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the KthLargestInBST problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.General.KthLargestInBSTTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;

namespace CodingExercises
{
    public class KthLargestInBST
    {
        public int kthLargest(Node root, int K)
        {
            IList<int> inorder = new List<int>();

            if (root != null)
            {
                Stack<Node> stack = new Stack<Node>();
                Node curr = root;

                while (curr != null || stack.Count > 0)
                {
                    while (curr != null)
                    {
                        stack.Push(curr);

                        curr = curr.left;
                    }

                    curr = stack.Pop();

                    inorder.Add(curr.data);

                    curr = curr.right;
                }
            }

            return inorder[inorder.Count - K];
        }
    }
}
