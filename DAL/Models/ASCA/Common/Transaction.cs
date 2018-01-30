// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System;

namespace DAL.Models
{
    public class Transaction: AuditableEntity
    {
        public int Id { get; set; }

        public TransactionType TransactionType { get; set; }

        public Account Account { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Details { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }


        //void AddTransaction(Transaction transaction)
        //{

        //}
        //public void Deposit(Account account, decimal amount, string details)
        //{
        //    TransactionType = TransactionType.Deposit;
        //    Debit = amount;
        //    Details = details;
        //}

        //public void Withdrawal(Account account, decimal amount, string _details)
        //{
        //    TransactionType = TransactionType.Withdrawal;
        //    Credit = amount;
        //    Details = _details;

        //}

        //public void Transfer(Account fromAccount, Account toAccount, decimal Amount, string _details)
        //{
        //    TransactionType = TransactionType.Transfer;
        //    Details=string.Format("Transfer from {0} to {1}",fromAccount.AccountNo, toAccount.AccountNo) + _details;

        //}
    }

}
