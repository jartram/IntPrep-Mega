/*
 =======================================================================================
 CHALLENGE: LowestCommonAncestor
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LowestCommonAncestor problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LowestCommonAncestorTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class LowestCommonAncestor
    {
        public TreeNode Solve(TreeNode root, TreeNode p, TreeNode q)
        {
            var p1 = root;

            while (p1 != null)
            {
                if (p1.val == p.val)
                {
                    return p;
                }

                if (p1.val == q.val)
                {
                    return q;
                }

                if ((p.val > p1.val && q.val < p1.val) || (q.val > p1.val && p.val < p1.val))
                {
                    return p1;
                }

                if (p.val > p1.val)
                {
                    p1 = p1.right;
                }
                else
                {
                    p1 = p1.left;
                }
            }

            return p1;
        }
    }
}
