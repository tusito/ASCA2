using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Transference: Transaction
    {
        public Account FromAccount{ get; set; }
        public Account ToAccount { get; set; }
    }
}
