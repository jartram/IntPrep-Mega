/*
 =======================================================================================
 CHALLENGE: IsSubtree
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the IsSubtree problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.IsSubtreeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class IsSubtree
    {
        public bool Solve(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;

            if (s == null || t == null) return false;

            return Traverse(s, t) || Solve(s.left, t) || Solve(s.right, t);
        }

        public bool Traverse(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;

            if (s == null || t == null) return false;

            return s.val == t.val && Traverse(s.left, t.left) && Traverse(s.right, t.right);
        }
    }
}
