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
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter24_DefiningCustomClasses.TeachTheTeacher.UnitTestTeacher
 =======================================================================================
*/

using System;

namespace CSharpPractical.Chapter24_DefiningCustomClasses.TeachTheTeacher
{
    public class Teacher
    {
        private string firstname = "";
        private string lastname = "";

        public void SetFirstname(string fn) => firstname = fn;
        public void SetLastname(string ln) => lastname = ln;

        public string Fullname() => $"{firstname} {lastname}";
        public string Email() => $"{firstname.ToLower()}.{lastname.ToLower().Replace(" ", "")}@vives.be";

        public override string ToString() => $"{Fullname()} <{Email()}>";
    }
}
