/*
 =======================================================================================
 CHALLENGE: ProgrammingBugs (04-storing-data)
 CHAPTER: Chapter04_StoringData
 
 DESCRIPTION:
 * # Programming Bugs
 *
 * This little application shows a funny message of the day. Or is was suppose to do this.
 *
 * The method `ShowMessage` in the file `ProgrammingBugs\MessageOfTheDay.s` need further implementation. The message and author are already there. But they are suppose to be concatenated in a bit of a special way. Don't change the original variables `message` and `author`. The author is prefixed with a tab-character to make it indented and also surrounded with double quotes.
 *
 * Expected output:
 *
 * ```text
 * If debugging is the process of removing software bugs, then programming must be the process of putting them in.
 *         By "Edsger Dijkstra"
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter04_StoringData.ProgrammingBugs.UnitTestMessageOfTheDay
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter04_StoringData.ProgrammingBugs
{
    public class MessageOfTheDay
    {
        public string ShowMessage()
        {
            string message = "If debugging is the process of removing software bugs, " +
                "then programming must be the process of putting them in.";

            string author = "Edsger Dijkstra";

            // TODO: Add quoted author to the message (on a new line), also prefix author with tab
            string authoredMessage = "";

            Console.WriteLine(authoredMessage);

            // Please dont change the code below (automatic unit tests)
            return authoredMessage;
        }
    }
}
