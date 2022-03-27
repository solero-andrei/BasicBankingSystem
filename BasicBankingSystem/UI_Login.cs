using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    public class UI_Login
    {
        public static Customer Login()
        {
            Customer customer = new Customer();
            bool isValidLogin = false;
            Customer customerInfo = null;

            while (isValidLogin == false)
            {
                Console.Write("Please enter your pincode: ");
                int pincode = int.Parse(Console.ReadLine());

                customerInfo = customer.FindUser(pincode);

                if(customerInfo.UserID == null)
                {
                    Console.Clear();
                    Console.WriteLine("Account not found. Please try again.");
                    isValidLogin = false;
                }
                else
                {
                    isValidLogin = true;
                    Console.Clear();
                }
            }

            return customerInfo;
        }
    }
}
