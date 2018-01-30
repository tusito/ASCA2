// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class ASCA
    {
        public int Id { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }

    }
}