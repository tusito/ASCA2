using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class City: AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
    }
}
