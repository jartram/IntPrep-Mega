using System;
using Xunit;
using CodingExercises.OOD.StackOverflow;

namespace CodingExercises.Tests.OOD;

public class StackOverflowModelTests
{
    [Fact]
    public void TestAccountResetPassword()
    {
        var account = new Account();
        account.Username = "alice";
        account.Password = "oldpass";
        Assert.True(account.ResetPassword("newpass"));
        Assert.Equal("newpass", account.Password);
    }

    [Fact]
    public void TestQuestionClose()
    {
        var q = new Question();
        // Default not closed
        Assert.False(q.Close());
    }
}
