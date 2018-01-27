using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Loan : Account
    {
        public decimal LoandAmount { get; set; }
        public decimal InterestRate { get; set; }
        public int Term { get; set; }
        public decimal Principal { get; set; }
        public decimal TotalInterestPaid { get; set; }
        public int NumPayments { get; set; }
    }
}
