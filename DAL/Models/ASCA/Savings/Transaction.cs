using System;

namespace DAL.Models
{
    public abstract class Transaction: AuditableEntity
    {
        public int Id { get; set; }

        public DateTime TransactionDate { get; set; }
        public string Comments { get; set; }
    }
}
