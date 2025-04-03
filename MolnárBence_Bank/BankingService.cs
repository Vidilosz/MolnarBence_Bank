using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolnárBence_Bank
{
    abstract class BankingService
    {
        public OwnerR Owner { get; }
        protected BankingService(OwnerR owner) => Owner = owner;
    }
}
