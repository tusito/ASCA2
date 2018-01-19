// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Currency : AuditableEntity
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public string Name {get; set; }
        public string Symbol { get; set; }
    }

    
}
