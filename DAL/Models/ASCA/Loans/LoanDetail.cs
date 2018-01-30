using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class LoanDetail
    {
        public int Id { get; set; }

        public int SavingId { get; set; }
        public int LoanId { get; set; }

        public decimal Amount { get; set; }
    }
}
