/*
 =======================================================================================
 CHALLENGE: Comment (Object-Oriented Design)
 CATEGORY: OOD / StackOverflow
 
 DESCRIPTION:
 Implement the object-oriented design component for Comment.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.OOD.CommentTests
 =======================================================================================
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercises.OOD.StackOverflow
{
    public class Comment
    {
        public long Id { get; set; }

        public string Content { get; set; }

        public int Upvote { get; set; }

        public int FlagCount { get; set; }

        public Member Owner { get; set; }

        public DateTime CreationTime { get; set; }

    }
}
