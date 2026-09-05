using CodingExercises.Solutions.Shared;
using CodingExercises.Solutions.CommonExercises;
using System;

namespace CodingExercises.Solutions.MicrosoftExcercises.Easy
{
    public class DiameterOfBinaryTree
    {
        private int diameter;

        public int Solve(TreeNode root)
        {
            diameter = 0;

            DiameterOfBinaryTreeAux(root);

            return diameter;
        }

        public int DiameterOfBinaryTreeAux(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                var left = DiameterOfBinaryTreeAux(root.left);
                var right = DiameterOfBinaryTreeAux(root.right);

                diameter = Math.Max(diameter, left + right);

                return Math.Max(left, right) + 1;
            }
        }
    }
}
