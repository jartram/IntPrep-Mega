/*
 =======================================================================================
 CHALLENGE: UniqueEmailAddress
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the UniqueEmailAddress problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.UniqueEmailAddressTests
 =======================================================================================
*/

using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Easy
{
    public class UniqueEmailAddress
    {
        public int NumUniqueEmails(string[] emails)
        {
            var finalEmails = new HashSet<string>();

            foreach (var email in emails)
            {
                var parseEmail = new StringBuilder();
                var atSignfound = false;
                var plusSignFound = false;

                for (var i = 0; i < email.Length; i++)
                {
                    var actual = email[i];

                    atSignfound |= actual == '@';
                    plusSignFound |= actual == '+';

                    if (atSignfound)
                    {
                        parseEmail.Append(actual);
                    }
                    else if (!plusSignFound && actual != '.')
                    {
                        parseEmail.Append(actual);
                    }
                }

                finalEmails.Add(parseEmail.ToString());

            }

            return finalEmails.Count;
        }
    }
}
