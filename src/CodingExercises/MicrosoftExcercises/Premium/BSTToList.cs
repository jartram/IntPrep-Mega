/*
 =======================================================================================
 CHALLENGE: BSTToList
 CATEGORY: MicrosoftExcercises / Premium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the BSTToList problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.BSTToListTests
 =======================================================================================
*/

﻿namespace CodingExercises.MicrosoftExcercises.Premium
{
    public class BSTToList
    {
        private Node last;
        private Node first;

        public Node TreeToDoublyList(Node root)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
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
