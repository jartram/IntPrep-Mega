/*
 =======================================================================================
 CHALLENGE: MaximumWidthBinaryTree
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the MaximumWidthBinaryTree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.MaximumWidthBinaryTreeTests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;
using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class MaximumWidthBinaryTree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public class LabeledNode
        {
            public TreeNode Node { get; set; }
            public int Position { get; set; }
            public LabeledNode(TreeNode node, int position)
            {
                Node = node;
                Position = position;
            }
        }
    }
}
