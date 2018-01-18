// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System;

namespace DAL.Models
{
    public class Transaction : AuditableEntity
    {
        public int Id { get; set; }
        public ASCA ASCA { get; set; }
        public Account Account { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Comments { get; set; }

        public int Execute(ASCA ASCA, Account account, decimal amount, TransactionType TransactionType)
        {
            return 0;
        }

        public int Execute(ASCA ASCA, Account AccountOrigin, Account AccountTarget, decimal amount)
        {
            TransactionType = TransactionType.Transfer;


            return 0;
        }
    }



    
}
