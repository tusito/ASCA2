using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Company_PayReollRep : AuditableEntity
    {
        public int Id { get; set; }
        public Company Company { get; set; }
        public Person PayRollRep { get; set; }
    }
}
