using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SisDelivery.Infraestrutura
{
    public class TransactionScopeDefault
    {
        public static TransactionScope CreateTransactionScope()
        {
            var transactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.MaxValue
            };
            return new TransactionScope(TransactionScopeOption.Required
                , transactionOptions);
        }
        
    }
}
