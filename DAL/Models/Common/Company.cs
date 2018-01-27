// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System.Collections.Generic;

namespace DAL.Models
{
    public class Company : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Country Country { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
