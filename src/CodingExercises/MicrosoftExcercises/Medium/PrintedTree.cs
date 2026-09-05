/*
 =======================================================================================
 CHALLENGE: PrintedTree
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PrintedTree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.PrintedTreeTests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class PrintedTree
    {
        public class Solution
        {
            public IList<IList<string>> PrintTree(TreeNode root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
        }

        public class LabeledNode
        {
            public TreeNode Node { get; set; }
            public TreeNode Parent { get; set; }
            public bool IsLeft { get; set; }

            public LabeledNode(TreeNode node, TreeNode parent, bool isLeft)
            {
                Node = node;
                Parent = parent;
                IsLeft = isLeft;
            }
        }
    }
}
