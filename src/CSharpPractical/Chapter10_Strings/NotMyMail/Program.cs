/*
 =======================================================================================
 CHALLENGE: NotMyMail (10-strings)
 CHAPTER: Chapter10_Strings
 
 DESCRIPTION:
 * # Not My Mail
 *
 * This application allows you to check the correctness of an email address. This is based on a number of basic checks.
 *
 * The `EmailValidator` class is able to check whether an email has a valid basic format. The method `IsValidEmail ()` should return `true` if the email address meets the following basic checks:
 *
 * * The email address contains an at `@`
 * * The email address contains a dot `.` after the `@` with at least 1 letter in between
 * * The email address has at least 1 letter before the `@`
 * * At least 1 letter is present after the last dot.
 *
 * Your tasks (also see `View => Task List` in Visual Studio):
 *
 * * Implement the `IsValidEmail()` method in the `EmailValidator` class so that it checks the `email` string for a valid email address.
 *
 * ## Expected output
 *
 * ```text
 * Welcome to email validator ...
 * Please enter email to check. Leave empty to stop.: nico.dewitte@vives.be
 * This is a valid email address
 * Please enter email to check. Leave empty to stop.: nico.vives.be
 * This email address is NOT valid
 * Please enter email to check. Leave empty to stop.: nico@vives
 * This email address is NOT valid
 * Please enter email to check. Leave empty to stop.: nico
 * This email address is NOT valid
 * Please enter email to check. Leave empty to stop.: nicodewitte@vives.be
 * This is a valid email address
 * Please enter email to check. Leave empty to stop.:
 * Thanks for using our validation app.
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter10_Strings.NotMyMail.UnitTestEmailValidator
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter10_Strings.NotMyMail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to email validator ...");

            EmailValidator validator = new EmailValidator();
            string email = "";
            do
            {
                Console.Write("Please enter email to check. Leave empty to stop.: ");
                email = Console.ReadLine();
                if (email != "")
                {
                    if (validator.IsValidEmail(email))
                    {
                        Console.WriteLine("This is a valid email address");
                    }
                    else
                    {
                        Console.WriteLine("This email address is NOT valid");
                    }
                }
            } while (email != "");

            Console.WriteLine("Thanks for using our validation app.");
        }
    }
}
