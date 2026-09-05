using System.Reflection;
using System.Text.RegularExpressions;
using System;
using Xunit;
using CSharpPractical.Chapter05_ProcessingData.CalculateVat;

namespace CSharpPractical.Tests.Chapter05_ProcessingData.CalculateVat;

public class UnitTestInvoice
    {
        private Invoice uut = new Invoice();

        private TReturn GetPrivateField<TReturn>(string fieldname)
        {
            Type type = uut.GetType();
            BindingFlags bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            FieldInfo field = type.GetField(fieldname, bindingAttr);
            return (TReturn)field.GetValue(uut);
        }

        [Fact]
        public void TestGetVAT()
        {
            double expected = GetPrivateField<double>("netPrice") * GetPrivateField<double>("vatPercentage") / 100;
            Assert.Equal(expected, uut.GetVAT(), 2);
        }
    }
