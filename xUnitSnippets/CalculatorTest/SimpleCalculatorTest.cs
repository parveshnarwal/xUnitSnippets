using Calculator;
using System;
using Xunit;

namespace CalculatorTest
{
    public class SimpleCalculatorTest
    {
        private readonly SimpleCalculator calculator;

        public SimpleCalculatorTest()
        {
            calculator = new SimpleCalculator();
        }

        [Fact]
        public void Add_Method_Test()
        {
            var result = calculator.Add(2, 3);

            //Using Assert.Equal to validate the result from method
            Assert.Equal(5, result);
        }

        [Fact]
        public void IsEven_Method_Returs_True_With_EvenNumber()
        {
            var result = calculator.IsEven(4);

            Assert.True(result);
        }

        [Fact]
        public void IsEven_Method_Returs_False_With_OddNumber()
        {
            var result = calculator.IsEven(3);

            Assert.False(result);
        }
    }
}
