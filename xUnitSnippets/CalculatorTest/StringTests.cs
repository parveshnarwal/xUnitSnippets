using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTest
{
    public class StringTests
    {
        private readonly Names names;
        public StringTests()
        {
            names = new Names();
        }


        [Fact]
        public void MakeFullNameTest()
        {
            var result = names.MakeFullName("John", "Doe");

            //Asserting case sensitive test

            Assert.Equal("John Doe", result);
        }

        [Fact]
        public void MakeFullNameTest_IgnoringCase()
        {
            var result = names.MakeFullName("John", "Doe");

            //Asserting case sensitive test

            Assert.Equal("john doe", result, ignoreCase:true);
        }

        [Fact]
        public void MakeFullNameTest_ContainsTest()
        {
            var result = names.MakeFullName("John", "Doe");

            //Using Assert.Contains method to check if output string contains a particular string

            Assert.Contains("hn Doe", result);

            //NOTE: Above method can be used with ignoreCase parameter similar to Assert.Equal
        }


        [Fact]
        public void MakeFullNameTest_StartsWith_EndsWith()
        {
            var result = names.MakeFullName("John", "Doe");

            //Using Starts With and Ends with methods
            Assert.StartsWith("John", result);
            Assert.EndsWith("Doe", result);
        }

        [Fact]
        public void MakeFullNameTest_UsingRegularExpression()
        {
            var result = names.MakeFullName("John", "Doe");

            //Regular expression to check 
            //1. First word must start with exactly one upper case
            //2. Second word must start with exactly one upper case
            //3. There should be one space between both words

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void MakeFullNameTest_UsingRegularExpression_WithDoesNotMatches()
        {
            var result = names.MakeFullName("John", "Doe");

            Assert.DoesNotMatch("[A-Z]{2}[a-z]+ [A-Z]{1}[a-z]+", result);
        }


        [Fact]
        public void NickName_MustBeNull()
        {
            var result = names.NickName;
            Assert.Null(result);
        }


        [Fact]
        public void NickName_MustBeNotNull()
        {
            names.NickName = "John";
            var result = names.NickName;
            Assert.NotNull(result);
        }

        [Fact]
        public void MakeFullNameTest_AlwaysReturValue()
        {
            var result = names.MakeFullName("John", "Doe");

            Assert.NotNull(result);

            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
