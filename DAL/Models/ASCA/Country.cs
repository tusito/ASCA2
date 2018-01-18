// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

namespace DAL.Models
{
    public class Country : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}