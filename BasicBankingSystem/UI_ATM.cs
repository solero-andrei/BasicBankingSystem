using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    public class UI_ATM
    {
        public static int MainMenu()
        {
            StandardMessages.Welcome();

            Console.WriteLine("-----Please select service:");
            Console.WriteLine("-----Press 1 for Balance Inquiry");
            Console.WriteLine("-----Press 2 for Withdraw");
            Console.WriteLine("-----Press 3 for Deposit");
            Console.WriteLine("-----Press 4 for Money Transfer");
            Console.WriteLine("-----Press 5 for Signout");
            Console.WriteLine();
            Console.Write(":- ");

            int choice = int.Parse(Console.ReadLine());
            return choice;
        }


    }
}
