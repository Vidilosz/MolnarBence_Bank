using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolnárBence_Bank
{
    class Bank
    {
        private readonly List<BankAccount> accounts = new();
        private readonly int maxAccounts;

        public Bank(int maxAccounts) => this.maxAccounts = maxAccounts;

        public BankAccount NewAccount(OwnerR owner, decimal creditLimit)
        {
            if (accounts.Count >= maxAccounts) throw new InvalidOperationException("Bank is full.");

            BankAccount account = creditLimit > 0 ? new CreditAccount(owner, creditLimit) : new SavingsAccount(owner);
            accounts.Add(account);
            return account;
        }

        public decimal TotalBalance(OwnerR owner) => accounts.Where(a => a.Owner == owner).Sum(a => a.Balance);

        public BankAccount MaximalBalanceAccount(OwnerR owner) => accounts.Where(a => a.Owner == owner).OrderByDescending(a => a.Balance).FirstOrDefault();

        public decimal TotalCreditLimit() => accounts.OfType<CreditAccount>().Sum(a => a.CreditLimit);
    }
}
