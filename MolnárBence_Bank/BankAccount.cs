using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolnárBence_Bank
{
    class BankAccount : BankingService
    {
        public decimal Balance { get; protected set; }
        public BankAccount(OwnerR owner) : base(owner) { }

        public void Deposit(decimal amount) => Balance += amount;
        public virtual bool Withdraw(decimal amount) => throw new NotImplementedException();

        public BankCard NewCard(string cardNumber) => new BankCard(Owner, this, cardNumber);
    }
}
