/*
 =======================================================================================
 CHALLENGE: KthElementInBST
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the KthElementInBST problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.KthElementInBSTTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class KthElementInBST
    {
        private int currentNumber;
        private int finalNumber;

        public int KthSmallest(TreeNode root, int k)
        {
            currentNumber = k;

            CreateInorderBSTList(root);

            return finalNumber;
        }

        public void CreateInorderBSTList(TreeNode root)
        {
            if (root != null && currentNumber != 0)
            {
                CreateInorderBSTList(root.left);
                currentNumber--;

                if (currentNumber == 0)
                {
                    finalNumber = root.val;
                }

                CreateInorderBSTList(root.right);
            }
        }
    }
}
