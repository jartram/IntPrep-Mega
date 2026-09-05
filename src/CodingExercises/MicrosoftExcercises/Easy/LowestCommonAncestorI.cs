/*
 =======================================================================================
 CHALLENGE: LowestCommonAncestorI
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LowestCommonAncestorI problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LowestCommonAncestorITests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class LowestCommonAncestorI
    {
        public TreeNode Solve(TreeNode root, TreeNode p, TreeNode q)
        {
            var actual = root;

            while (actual != null)
            {
                if ((actual.val >= p.val && actual.val <= q.val) ||
                  (actual.val <= p.val && actual.val >= q.val))
                {
                    return actual;
                }
                else if (actual.val > p.val && actual.val > q.val)
                {
                    actual = actual.left;
                }
                else
                {
                    actual = actual.right;
                }
            }

            return actual;
        }
    }
}
