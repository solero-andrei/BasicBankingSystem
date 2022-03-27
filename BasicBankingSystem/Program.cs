using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.Welcome();

            Customer custInfo = UI_Login.Login();

            int selectedService = UI_ATM.MainMenu();

            ATMServiceController service = new ATMServiceController(selectedService, custInfo);
            service.ProcessService();

            Console.ReadLine();
        }
    }
}
