/*
 =======================================================================================
 CHALLENGE: ValidateBST
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the ValidateBST problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.ValidateBSTTests
 =======================================================================================
*/

namespace CodingExercises.Exercises
{
    public class ValidateBST
    {
        //Recursive way
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, null, null);
        }

        private bool IsValidBST(TreeNode root, int? min, int? max)
        {
            if (root == null)
            {
                return true;
            }

            if ((min != null && min >= root.val) || (max != null && max <= root.val))
            {
                return false;
            }

            return IsValidBST(root.left, min, root.val) && IsValidBST(root.right, root.val, max);
        }
    }
}
