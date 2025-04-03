using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolnárBence_Bank
{
    class SavingsAccount : BankAccount
    {
        public static decimal DefaultInterestRate { get; set; } = 0.02m;
        public decimal InterestRate { get; set; }

        public SavingsAccount(OwnerR owner) : base(owner) => InterestRate = DefaultInterestRate;

        public override bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void AddInterest() => Balance += Balance * InterestRate;
    }

}
