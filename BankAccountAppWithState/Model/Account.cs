using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAppWithState.Model
{
    [Serializable]
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public Account(int accountNumber, string accountHolderName, string bankName, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            BankName = bankName;
            Balance = balance;
        }
    }
}
