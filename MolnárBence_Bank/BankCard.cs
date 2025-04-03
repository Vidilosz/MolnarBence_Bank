using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolnárBence_Bank
{
    class BankCard : BankingService
    {
        public string CardNumber { get; }
        public BankAccount LinkedAccount { get; }

        public BankCard(OwnerR owner, BankAccount account, string cardNumber) : base(owner)
        {
            LinkedAccount = account;
            CardNumber = cardNumber;
        }

        public bool Purchase(decimal amount) => LinkedAccount.Withdraw(amount);
    }
}
