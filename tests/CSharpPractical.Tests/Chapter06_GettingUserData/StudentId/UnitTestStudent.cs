using System.Reflection;
using System.Text.RegularExpressions;
using System;
using Xunit;
using CSharpPractical.Chapter06_GettingUserData.StudentId;

namespace CSharpPractical.Tests.Chapter06_GettingUserData.StudentId;

public class UnitTestStudent
    {
        private Student uut = new Student();

        private TReturn GetPrivateField<TReturn>(string fieldname)
        {
            Type type = uut.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            FieldInfo field = type.GetField(fieldname, bindingAttr);
            return (TReturn)field.GetValue(uut);
        }

        [Fact]
        public void TestEmail()
        {
            string email = $"{GetPrivateField<string>("firstname")}.{GetPrivateField<string>("lastname")}@student.vives.be";
            Assert.Equal(email.ToLower(), uut.Email());
        }

        [Fact]
        public void TestID()
        {
            Assert.True(Regex.Match(uut.ID(), @"^r\d{6}$").Success, "Incorrect ID format");
        }
    }
