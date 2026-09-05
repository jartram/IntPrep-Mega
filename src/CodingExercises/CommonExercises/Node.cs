/*
 =======================================================================================
 CHALLENGE: Node
 CATEGORY: CommonExercises
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the Node problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.NodeTests
 =======================================================================================
*/

namespace CodingExercises.Exercises
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node next;
        private object val;

        public Node(object val)
        {
            this.val = val;
        }

        Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
