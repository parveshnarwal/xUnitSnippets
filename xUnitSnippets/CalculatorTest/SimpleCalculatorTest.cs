using Calculator;
using Xunit;

namespace CalculatorTest
{
    [Collection("Calculator")]
    public class SimpleCalculatorTest
    {

        private readonly CalculatorFixture _calculatorFixture;
        
        public SimpleCalculatorTest(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Fact]
        public void Add_Method_Test()
        {
            SimpleCalculator calc = _calculatorFixture.SimpleCalculator;

            var result = calc.Add(2, 3);

            //Using Assert.Equal to validate the result from method
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_Method_Test()
        {
            SimpleCalculator calc = _calculatorFixture.SimpleCalculator;

            var result = calc.Subtract(10, 2);

            Assert.Equal(8, result);

            //Assert.NotEqual to validate output
            Assert.NotEqual(-8, result);

        }


        //Using Trait attribute to group test cases
        //Trait attribute can be used to group intergration test cases and unit test cases
        //So that they can be executed separately if requried 
        [Fact]
        [Trait("Category","IsEven Method")]
        public void IsEven_Method_Returs_True_With_EvenNumber()
        {
            SimpleCalculator calc = _calculatorFixture.SimpleCalculator;

            var result = calc.IsEven(4);

            //Using Assert.True to check if result is true or not
            Assert.True(result);
        }

        [Fact]
        [Trait("Category", "IsEven Method")]
        public void IsEven_Method_Returs_False_With_OddNumber()
        {
            SimpleCalculator calc = _calculatorFixture.SimpleCalculator;

            var result = calc.IsEven(3);

            //Using Assert.False to check if result is false or not
            Assert.False(result);
        }

        [Fact]
        public void IsOdd_GivenOddValue_RetursTrue()
        {
            SimpleCalculator calc = _calculatorFixture.SimpleCalculator;

            var result = calc.IsOdd(5);

            Assert.True(result);

        }

        //DATA DRIVEN TEST CASES

        [Theory]
        [InlineData(1, true)]
        [InlineData(600, false)]
        [InlineData(7, true)]
        public void IsOdd_TestOddAndEvenNumber(int value, bool expected)
        {
            SimpleCalculator calc = _calculatorFixture.SimpleCalculator;

            var result = calc.IsOdd(value);

            Assert.Equal(expected, result);
        }


        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEvenNumber_DataSharing(int value, bool expected)
        {
            SimpleCalculator calc = _calculatorFixture.SimpleCalculator;

            var result = calc.IsOdd(value);

            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenDataFromExternalFile), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEvenNumber_DataSharing_UsingExternalFile(int value, bool expected)
        {
            SimpleCalculator calc = _calculatorFixture.SimpleCalculator;

            var result = calc.IsOdd(value);

            Assert.Equal(expected, result);
        }

        [Theory]
        [IsOddOrEvenData]
        public void IsOdd_TestOddAndEvenNumber_DataSharing_UsingCustomAttribute(int value, bool expected)
        {
            SimpleCalculator calc = _calculatorFixture.SimpleCalculator;

            var result = calc.IsOdd(value);

            Assert.Equal(expected, result);
        }


    }
}
