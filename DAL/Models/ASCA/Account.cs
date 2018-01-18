// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

namespace DAL.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public Contributor Contributor { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance { get; set; }
    }
}