using System.Collections.Generic;

namespace LittleLittleTinyBank.Classes
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public int Number { get; set; }
        public BankAccountType Type { get; set; }
        public List<Transaction> Transactions { get; set; }

        public enum BankAccountType
        {
            Savings,
            Checking
        }
    }
}
