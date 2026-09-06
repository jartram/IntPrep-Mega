/*
 =======================================================================================
 CHALLENGE: BSTIterator
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BSTIterator problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BSTIteratorTests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class BSTIterator
    {

        private int Index;
        private IList<TreeNode> Iterator;

        public BSTIterator(TreeNode root)
        {
            Index = 0;
            Iterator = new List<TreeNode>();

            var actual = root;
            var stack = new Stack<TreeNode>();

            while (actual != null || stack.Count > 0)
            {
                while (actual != null)
                {
                    stack.Push(actual);
                    actual = actual.left;
                }

                actual = stack.Pop();

                Iterator.Add(actual);

                actual = actual.right;
            }
        }

        public int Next()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public bool HasNext()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
