// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Relationship : AuditableEntity
    {
        public int Id { get; set; }
        public Person Person1 { get; set; }
        public Person Person2 { get; set; }
        public RelationshipType RleationshipType { get; set; }
    }
}
