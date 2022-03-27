using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    public interface IATMService
    {
        void Withdraw();
        void Deposit();
        void BalanceInquiry();
        void MoneyTransfer();

    }
}
