/*
 =======================================================================================
 CHALLENGE: SymmetricTree
 CATEGORY: CommonExercises / Easy-Trees
 SOURCE: https://leetcode.com/explore/interview/card/top-interview-questions-easy/94/trees/627/
 
 DESCRIPTION:
 Solve the SymmetricTree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.SymmetricTreeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/explore/interview/card/top-interview-questions-easy/94/trees/627/
namespace CodingExercises.CommonExercises.Easy_Trees
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var listLeft = new List<int?>();
            var queue = new Queue<TreeNode>();

            queue.Enqueue(root.left);

            while (queue.Count > 0)
            {
                var actual = queue.Dequeue();

                if (actual == null)
                {
                    listLeft.Add(null);
                }
                else
                {
                    listLeft.Add(actual.val);
                }

                if (actual != null)
                {
                    queue.Enqueue(actual.left);
                    queue.Enqueue(actual.right);
                }
            }

            queue.Enqueue(root.right);


            var listRight = new List<int?>();

            while (queue.Count > 0)
            {
                var actual = queue.Dequeue();

                if (actual == null)
                {
                    listRight.Add(null);
                }
                else
                {
                    listRight.Add(actual.val);
                }

                if (actual != null)
                {
                    queue.Enqueue(actual.right);
                    queue.Enqueue(actual.left);
                }
            }

            if (listLeft.Count != listRight.Count)
            {
                return false;
            }

            for (int i = 0; i < listLeft.Count - 1; i++)
            {
                if (listLeft.ElementAt(i) != listRight.ElementAt(i))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
