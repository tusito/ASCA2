// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;

namespace DAL.Models
{
    public class Employee: AuditableEntity
    {
        public string EmployeeId { get; set; }
        public Person Person { get; set; }
        public Department Department { get; set; }
        public Company Company { get; set; }
    }
}
