// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System.Collections.Generic;

namespace DAL.Models
{
    public class Saving
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public decimal AvailableToLoan { get; set; }
        public ICollection<LoanDetail> LoansCollections { get; set; }
    }
}
