/*
 =======================================================================================
 CHALLENGE: PathSumII
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the PathSumII problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.PathSumIITests
 =======================================================================================
*/

﻿using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class PathSumII
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        private void PathSum(TreeNode root,
                            int targetSum,
                            int currentSum,
                            IList<int> current,
                            IList<IList<int>> pathSums)
        {
            if (root == null)
            {
                return;
            }

            current.Add(root.val);

            var sum = currentSum + root.val;

            if (sum == targetSum && root.left == null && root.right == null)
            {
                pathSums.Add(current.ToList());
            }

            PathSum(root.left, targetSum, sum, current, pathSums);
            PathSum(root.right, targetSum, sum, current, pathSums);

            current.RemoveAt(current.Count - 1);
        }
    }
}
