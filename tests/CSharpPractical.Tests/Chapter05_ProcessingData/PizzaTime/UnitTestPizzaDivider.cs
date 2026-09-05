using System.Reflection;
using System.Text.RegularExpressions;
using System;
using Xunit;
using CSharpPractical.Chapter05_ProcessingData.PizzaTime;

namespace CSharpPractical.Tests.Chapter05_ProcessingData.PizzaTime;

public class UnitTestPizzaDivider
    {
        private PizzaDivider uut = new PizzaDivider();

        private TReturn GetPrivateField<TReturn>(string fieldname)
        {
            Type type = uut.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            FieldInfo field = type.GetField(fieldname, bindingAttr);
            return (TReturn)field.GetValue(uut);
        }

        [Fact]
        public void TestSlicesPerPerson()
        {
            int expected = GetPrivateField<int>("slicesOfPizza") / GetPrivateField<int>("numberOfPeople");
            Assert.Equal(expected, uut.HowManySlicesPerPerson());
        }

        [Fact]
        public void TestSlicesLeft()
        {
            int expected = GetPrivateField<int>("slicesOfPizza") % GetPrivateField<int>("numberOfPeople");
            Assert.Equal(expected, uut.HowManySlicesLeft());
        }
    }
