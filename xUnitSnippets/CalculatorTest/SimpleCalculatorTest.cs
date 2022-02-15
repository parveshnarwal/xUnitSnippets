using Calculator;
using System;
using Xunit;

namespace CalculatorTest
{
    public class SimpleCalculatorTest
    {
        private readonly SimpleCalculator calc;

        public SimpleCalculatorTest()
        {
            calc = new SimpleCalculator();
        }

        [Fact]
        public void Add_Method_Test()
        {
            var result = calc.Add(2, 3);

            //Using Assert.Equal to validate the result from method
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_Method_Test()
        {
            var result = calc.Subtract(10, 2);

            Assert.Equal(8, result);

            //Assert.NotEqual to validate output
            Assert.NotEqual(-8, result);

        }

        [Fact]
        public void IsEven_Method_Returs_True_With_EvenNumber()
        {
            var result = calc.IsEven(4);

            //Using Assert.True to check if result is true or not
            Assert.True(result);
        }

        [Fact]
        public void IsEven_Method_Returs_False_With_OddNumber()
        {
            var result = calc.IsEven(3);

            //Using Assert.False to check if result is false or not
            Assert.False(result);
        }
    }
}
