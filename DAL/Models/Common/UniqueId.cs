// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;

namespace DAL.Models
{
    public class UniqueID : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person Person { get; set; }
        public UniqueIdType Type { get; set; }
    }
}
