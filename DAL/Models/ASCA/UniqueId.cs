// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
