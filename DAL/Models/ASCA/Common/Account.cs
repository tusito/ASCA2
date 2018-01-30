// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Account : AuditableEntity
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public Contributor Owner { get; set; }
        public AccountType AccountType { get; set; }
        public Currency Currency { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

        public decimal GetBalance()
        {

            return 0;
        }

        void AddTransaction(Transaction t)
        {

        }
    }
}