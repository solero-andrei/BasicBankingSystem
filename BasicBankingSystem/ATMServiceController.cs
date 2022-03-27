using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    public class ATMServiceController
    {
        private int selectedService;
        private Customer customer;
        private IATMService service;
        public ATMServiceController(int selected, Customer customer)
        {
            this.selectedService = selected;
            this.customer = customer;
        }

        public void ProcessService()
        {
            service = new ATMService(customer);

            UIController.ClearScreen();

            switch (selectedService)
            {
                case 1:
                    service.BalanceInquiry();
                    break;
                case 2:
                    service.Withdraw();
                    break;
                case 3:
                    service.Deposit();
                    break;
                default:
                    break;
            }
        }

    }
}
