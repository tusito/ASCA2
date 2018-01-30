// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System;

namespace DAL.Models
{
    public class AmortizationScheduleRow
    {
        public int Id { get; set; }
        public int PaymentNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal BeginningBalance { get; set; }
        public decimal ScheduledPayment { get; set; }
        public decimal TotalPeyment { get; set; }
        public decimal Principal { get; set; }
        public decimal Interest { get; set; }
        public decimal EndingBalance { get; set; }
        public decimal CumulativeInterest { get; set; }
        public RowType RowType { get; set; }
    }
}