using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Customer
    {
        public string Name = "John Doe";
        public int Age = 24;

        public virtual int GetOrderIdByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name can not be blank");
            }

            return 100;
        }
    }

    public class LoyalCustomer : Customer
    {
        public int Discount { get; set; }

        public override int GetOrderIdByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name can not be blank");
            }

            return 101;
        }
    }

    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount > 50)
                return new LoyalCustomer();

            return new Customer();
        }
    }

}
