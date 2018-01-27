// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System.Collections.Generic;

namespace DAL.Models
{
    public class Country : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<State> States { get; set; }
    }
}