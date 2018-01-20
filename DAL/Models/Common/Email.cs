// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;

namespace DAL.Models
{
    public class Email : AuditableEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public EmailType PhoneType { get; set; }
        public bool IsPrimary { get; set; }
    }
}
