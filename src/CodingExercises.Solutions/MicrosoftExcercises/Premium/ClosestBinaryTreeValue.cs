using CodingExercises.Solutions.Shared;
using CodingExercises.Solutions.CommonExercises;
using System;

namespace CodingExercises.Solutions.MicrosoftExcercises.Premium
{
    public class ClosestBinaryTreeValue
    {
        public int ClosestValue(TreeNode root, double target)
        {
            int val, closest = root.val;
            while (root != null)
            {
                val = root.val;
                closest = Math.Abs(val - target) < Math.Abs(closest - target) ? val : closest;
                root = target < root.val ? root.left : root.right;
            }
            return closest;
        }
    }
}
