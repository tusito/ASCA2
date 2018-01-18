// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System;
using System.Collections.Generic;
using System.Text;
using DAL.Core;

namespace DAL.Models
{
    public class Phone : AuditableEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }
        public bool IsPrimary { get; set; }

    }
}
