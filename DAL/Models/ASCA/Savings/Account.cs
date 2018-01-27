// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Models.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Account : AuditableEntity
    {
        public int Id { get; set; }
        public ASCA ASCA { get; set; }
        public string AccountNo { get; set; }
        public Contributor Contributor { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}