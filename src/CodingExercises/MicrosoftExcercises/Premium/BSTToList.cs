/*
 =======================================================================================
 CHALLENGE: BSTToList
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BSTToList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.BSTToListTests
 =======================================================================================
*/

namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class BSTToList
    {
        private Node last;
        private Node first;

        public Node TreeToDoublyList(Node root)
        {
            if (root == null)
            {
                return null;
            }

            buildInorder(root);

            first.left = last;
            last.right = first;

            return first;
        }

        private void buildInorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            buildInorder(root.left);

            if (last == null)
            {
                first = root;
            }
            else
            {
                last.right = root;
                root.left = last;
            }

            last = root;

            buildInorder(root.right);
        }
    }
}
