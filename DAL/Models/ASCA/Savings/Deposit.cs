namespace DAL.Models
{
    public class Deposit: Transaction
    {
        public Account Account { get; set; }
    }
}
