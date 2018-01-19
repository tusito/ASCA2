// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Contributor : AuditableEntity
    {
        public int Id { get; set; }
        public Person Person { get; set; }

    }
}
