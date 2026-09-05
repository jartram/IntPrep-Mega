/*
 =======================================================================================
 CHALLENGE: DiameterOfBinaryTree
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DiameterOfBinaryTree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.DiameterOfBinaryTreeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;
using System;

namespace CodingExercises.MicrosoftExcercises.Easy
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
