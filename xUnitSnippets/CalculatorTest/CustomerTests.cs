using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTest
{
    public class CustomerTests
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = new Customer();

            Assert.NotNull(customer.Name);
            Assert.NotEqual(string.Empty, customer.Name);
        }

        [Fact]
        public void CheckIfLegitForDiscount()
        {
            var customer = new Customer();

            //Asserting age is between 18 and 40
            Assert.InRange(customer.Age, 18, 40);
        }

        [Fact]
        public void GetOrderIdByNameTest()
        {
            var customer = new Customer();
            
            //Checking if method throws exception
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrderIdByName(""));

            Assert.Equal("Name can not be blank", exceptionDetails.Message);
        }

        [Fact]
        public void CheckLoyalCustomerType()
        {
            var result = CustomerFactory.CreateCustomerInstance(150);

            //Using IsType method to make sure customer is Loyal Customer
            Assert.IsType<LoyalCustomer>(result);
        }
    }
}
