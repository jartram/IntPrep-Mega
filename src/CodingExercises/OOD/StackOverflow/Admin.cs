/*
 =======================================================================================
 CHALLENGE: Admin (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Admin.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.OOD.AdminTests
 =======================================================================================
*/

namespace CodingExercises.OOD.StackOverflow
{
    public class Admin : Member
    {
        public bool BlockMember(Member member) 
        {
            return false;
        }

        public bool UnblockMember(Member member)
        {
            return false;
        }
    }
}
