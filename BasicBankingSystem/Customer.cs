using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    public class Customer : User
    {
        public double currentBalance { get; set; }
        public override Customer FindUser(int pinCode)
        {
            Customer output = new Customer();
            var customers = GenerateUser.Customers();

            foreach (var customer in customers)
            {
                if(pinCode == customer.PinCode)
                {
                    output.FirstName = customer.FirstName;
                    output.LastName = customer.LastName;
                    output.PinCode = customer.PinCode;
                    output.UserID = customer.UserID;
                    output.currentBalance = customer.currentBalance;
                    output.Address = customer.Address;
                }
            }

            return output;
        }
    }
}
