// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class ASCA : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Currency Currency { get; set; }
        public ICollection<Contributor>  Contributors { get; set; }
        public Person Treasurer { get; set; }

    }
}