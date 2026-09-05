/*
 =======================================================================================
 CHALLENGE: LCA3
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the LCA3 problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.LCA3Tests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class LCA3
    {
        public Node LowestCommonAncestor(Node p, Node q)
        {
            var visited = new HashSet<Node>();

            var current = p;

            while (current != null)
            {
                visited.Add(current);

                current = current.parent;
            }

            current = q;

            while (current != null)
            {
                if (visited.Contains(current))
                {
                    return current;
                }

                current = current.parent;
            }

            return null;
        }
    }
}
