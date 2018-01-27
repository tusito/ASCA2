// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================


using System.Collections.Generic;

namespace DAL.Models
{
    public class State:AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
        public Country Country { get; set; }
    }
}
