/*
 =======================================================================================
 CHALLENGE: Teach The Teacher (24-defining-custom-classes)
 CHAPTER: Chapter24_DefiningCustomClasses
 
 DESCRIPTION:
 Implement a Teacher class to store personal details of a teacher including:
 - First name and last name setters
 - Fullname() returning "{firstname} {lastname}"
 - Email() returning "{firstname.ToLower()}.{lastname.ToLower().Replace(" ", "")}@vives.be"
 - ToString() returning "{Fullname()} <{Email()}>"
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter24_DefiningCustomClasses.TeachTheTeacher.UnitTestTeacher
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter24_DefiningCustomClasses.TeachTheTeacher;

public class Teacher
{
    public void SetFirstname(string firstname)
    {
        // TODO: Store teacher's first name
        throw new NotImplementedException();
    }

    public void SetLastname(string lastname)
    {
        // TODO: Store teacher's last name
        throw new NotImplementedException();
    }

    public string Fullname()
    {
        // TODO: Return full name
        throw new NotImplementedException();
    }

    public string Email()
    {
        // TODO: Return student/teacher email address
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        // TODO: Return formatted string
        throw new NotImplementedException();
    }
}
