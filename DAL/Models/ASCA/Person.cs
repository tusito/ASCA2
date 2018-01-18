// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DAL.Core;

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
        public ICollection<Phone> Phones { get; set; }
        public ICollection<UniqueID> UniqueIDs { get; set; }
    }
}
