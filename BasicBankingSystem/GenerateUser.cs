using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    public class GenerateUser
    {
        public static List<Customer> Customers()
        {
            List<Customer> output = new List<Customer>();
            output.Add(new Customer
            {
                FirstName = "Klay",
                LastName = "Thompson",
                PinCode = 1234,
                UserID = "00001",
                currentBalance = 15122,
                Address = "California"
            });
            output.Add(new Customer
            {
                FirstName = "Steph",
                LastName = "Curry",
                PinCode = 1235,
                UserID = "00002",
                currentBalance = 61236,
                Address = "LA"
            });
            output.Add(new Customer
            {
                FirstName = "Andre",
                LastName = "Iggy",
                PinCode = 1235,
                UserID = "00002",
                currentBalance = 157823,
                Address = "Oakland"
            });

            return output;
        }
    }
}
