// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================


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
