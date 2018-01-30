// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Address : AuditableEntity
    {
        public int Id { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int Zipcode { get; set; }
        public City City { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }

    }
}
