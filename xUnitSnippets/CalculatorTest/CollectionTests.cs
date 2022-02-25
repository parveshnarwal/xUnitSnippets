using Calculator;
using System.Collections.Generic;
using Xunit;

namespace CalculatorTest
{
    public class CollectionTests
    {
        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            var fiboSeries = new FibonacciSeries();
            Assert.All(fiboSeries.fibo, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboDoesNotIncludeZero_WithDoesNotContain()
        {
            var fiboSeries = new FibonacciSeries();
            Assert.DoesNotContain(0, fiboSeries.fibo);
        }

        [Fact]
        public void FiboIncludes13()
        {
            var fiboSeries = new FibonacciSeries();
            Assert.Contains(13, fiboSeries.fibo);
        }

        [Fact]
        public void CheckFibo()
        {
            var expectedFibo = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };

            var fiboSeries = new FibonacciSeries();
            Assert.Equal(expectedFibo, fiboSeries.fibo);
        }
    }
}
