// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Department : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company Company { get; set; }
    }
}
