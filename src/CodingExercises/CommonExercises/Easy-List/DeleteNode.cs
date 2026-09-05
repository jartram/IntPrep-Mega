/*
 =======================================================================================
 CHALLENGE: DeleteNode
 CATEGORY: CommonExercises / Easy-List
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the DeleteNode problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.DeleteNodeTests
 =======================================================================================
*/

using CodingExercises.Shared;
using CodingExercises.CommonExercises;

namespace CodingExercises.CommonExercises.Easy_List
{
    public class DeleteNode
    {
        public void Delete(ListNode node)
        {

            var aux = node;

            while (aux.next.next != null)
            {
                aux.val = aux.next.val;
                aux = aux.next;
            }

            aux.val = aux.next.val;
            aux.next = null;
        }
    }
}
