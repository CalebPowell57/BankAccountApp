using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleLittleTinyBank.Classes
{
    public class Transaction
    {
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public int Amount { get; set; }
        public int Remaining { get; set; }
        public TransactionType Type { get; set; } 

        public enum TransactionType
        { 
            Withdrawl,
            Deposit,
            Expense
        }
    }
}
