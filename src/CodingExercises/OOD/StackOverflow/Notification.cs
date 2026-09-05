/*
 =======================================================================================
 CHALLENGE: Notification (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Notification.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.OOD.NotificationTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercises.OOD.StackOverflow
{
    class Notification
    {
        private int notificationId;

        private DateTime createdOn;
        private string content;

        public bool SendNotification() 
        {
            return true;
        }
    }
}
