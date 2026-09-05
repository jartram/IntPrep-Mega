/*
 =======================================================================================
 CHALLENGE: StudentId (06-getting-user-data)
 CHAPTER: Chapter06_GettingUserData
 
 DESCRIPTION:
 * # Student ID
 *
 * The Student ID app is used by the administrative service of VIVES to generate email addresses and IDs for new students. However the generation of both the components has not been finished yet.
 *
 * Fix the method `Email()` so it returns an email address in the format `firstname.lastname@student.vives.be`. Make sure that all letters are lower case. You can search the Internet on how to lowercase a full string.
 *
 * Next an ID needs to be generated. For this you can use the `Random` class. Generate an ID number of `6` digits and prefix it with an `r`. Place the implementation inside of the `ID()` method.
 *
 * Expected Output:
 *
 * ```text
 * Student information:
 * Firstname: Marco
 * Lastname: Polo
 * Email: marco.polo@student.vives.be
 * ID: r123056
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter06_GettingUserData.StudentId.UnitTestStudent
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter06_GettingUserData.StudentId
{
    public class Student
    {
        // Feel free to change these values but keep them
        // with a capital letter to make sure your Email() method is correct
        string firstname = "Marco";
        string lastname = "Polo";

        public string Email()
        {
            // TODO: Generate email for the student in the following format:
            // firstname.lastname@student.vives.be
            // Make sure that all letters are lowercase letters
            string email = "";

            // Please dont change the code below (automatic unit tests)
            return email;
        }

        public string ID()
        {
            // TODO: Generate an ID for the student (random number of 6 digits)
            // Put it into the following format: rxxxxxx
            // r is a prefix and each x is a digit
            string id = "";

            // Please dont change the code below (automatic unit tests)
            return id;
        }

        public void PrintToTerminal()
        {
            Console.WriteLine("Student information:");
            Console.WriteLine($"Firstname: {firstname}");
            Console.WriteLine($"Lastname: {lastname}");
            Console.WriteLine($"Email: {Email()}");
            Console.WriteLine($"ID: {ID()}");
        }
    }
}
