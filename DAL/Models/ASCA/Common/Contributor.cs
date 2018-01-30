// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

namespace DAL.Models
{
    public class Contributor : AuditableEntity
    {
        public int Id { get; set; }
        public Person Person { get; set; }

    }
}
