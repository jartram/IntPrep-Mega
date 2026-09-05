/*
 =======================================================================================
 CHALLENGE: FindDuplicatesSubtree
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FindDuplicatesSubtree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FindDuplicatesSubtreeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class FindDuplicatesSubtree
    {
        public IList<TreeNode> duplicates = new List<TreeNode>();
        public Dictionary<string, int> trees = new Dictionary<string, int>();

        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            if (root == null)
            {
                return new List<TreeNode>();
            }

            Traverse(root);

            return duplicates;
        }

        public string Traverse(TreeNode root)
        {
            if (root == null)
            {
                return "#";
            }

            var subTree = $"{root.val} {Traverse(root.left)} {Traverse(root.right)}";

            if (trees.ContainsKey(subTree))
            {
                if (trees[subTree] == 1)
                {
                    duplicates.Add(root);
                }
            }
            else
            {
                trees.Add(subTree, 0);
            }

            trees[subTree] += 1;

            return subTree;
        }
    }
}
