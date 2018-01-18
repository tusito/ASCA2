// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Company : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Country Country { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public Employee PayRollRep { get; set; }
    }
}
