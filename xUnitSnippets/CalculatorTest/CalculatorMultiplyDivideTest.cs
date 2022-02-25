using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTest
{
    [Collection("Calculator")]
    public class CalculatorMultiplyDivideTest
    {

        private readonly CalculatorFixture _calculatorFixture;

        public CalculatorMultiplyDivideTest(CalculatorFixture calculatorFixture)
        {
            _calculatorFixture = calculatorFixture;
        }

        [Fact]
        public void Multiply_Method_Test()
        {
            SimpleCalculator calculator = _calculatorFixture.SimpleCalculator;
            var result = calculator.Multiply(5, 5);

            Assert.Equal(25, result);
        }

        [Fact]
        public void Divide_Method_Test()
        {
            SimpleCalculator calculator = _calculatorFixture.SimpleCalculator;
            var result = calculator.Divide(15, 5);

            Assert.Equal(3, result);
        }
    }
}
