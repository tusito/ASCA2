// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Employee: AuditableEntity
    {
        public Person Person { get; set; }
        public string EmployeeId { get; set; }
        public Status Status { get; set; }
        public string CompanyAbbreviation { get; set; }
        public Company Company { get; set; }
        public Department Department { get; set; }
    }
}
