using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolnárBence_Bank
{
    class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; }
        public CreditAccount(OwnerR owner, decimal creditLimit) : base(owner) => CreditLimit = creditLimit;

        public override bool Withdraw(decimal amount)
        {
            if (Balance - amount >= -CreditLimit)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
