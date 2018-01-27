namespace DAL.Models
{
    public class Withdrawal : Transaction
    {
        public Account Account { get; set; }
    }
}
