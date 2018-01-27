// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Person : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Surname { get; set; }
        public string MothersMaidenName { get; set; }
        public Gender Gender { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<UniqueID> UniqueIDs { get; set; }
        public Address Address { get; set; }
    }
}
