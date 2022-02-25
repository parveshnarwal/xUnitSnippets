using Calculator;
using System;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace CalculatorTest
{

    //Adding Fixture class to make sure we are creating only one instance of Cusstomer class, this will help in memory management 
    public class CustomerFixture : IDisposable
    {
        public Customer Customer => new Customer();

        public void Dispose()
        {
            //Clean / Release the resources here 
        }
    }

    
    public class CustomerTests : IClassFixture<CustomerFixture>
    {
        private readonly CustomerFixture _customerFixture;

        //Test Out Helper class is used to debug code / write messages to out
        private readonly ITestOutputHelper _testOutputHelper;

        public CustomerTests(ITestOutputHelper testOutputHelper, CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
            _testOutputHelper = testOutputHelper;

            _testOutputHelper.WriteLine("Constructor CustomerTests was invoked");
            
        }

        [Fact]
        public void CheckNameNotEmpty()
        {
            //Adding messages using test output helper class
            _testOutputHelper.WriteLine("Creating instance of Customer Class using fixture");

            var customer = _customerFixture.Customer;

            Assert.NotNull(customer.Name);
            Assert.NotEqual(string.Empty, customer.Name);

            _testOutputHelper.WriteLine("Test CheckNameNotEmpty execution completed. Please verify results");
        }

        [Fact]
        public void CheckIfLegitForDiscount()
        {
            var customer = _customerFixture.Customer;

            //Asserting age is between 18 and 40
            Assert.InRange(customer.Age, 18, 40);
        }

        [Fact]
        public void GetOrderIdByNameTest()
        {
            var customer = _customerFixture.Customer;

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
