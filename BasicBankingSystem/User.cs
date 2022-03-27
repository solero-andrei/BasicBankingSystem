using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBankingSystem
{
    public abstract class User
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PinCode { get; set; }
        public string Address { get; set; }


        public abstract Customer FindUser(int pinCode);
    }
}
