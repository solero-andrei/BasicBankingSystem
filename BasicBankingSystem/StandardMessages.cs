using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    public class StandardMessages
    {
        public static void Welcome()
        {
            Console.WriteLine("-------Welcome to ATM System-------");
            Console.WriteLine();
        }

        public static void ProceedToMenu()
        {
            Console.WriteLine("Please enter any key to continue...");
            Console.ReadKey();
        }

    }
}
