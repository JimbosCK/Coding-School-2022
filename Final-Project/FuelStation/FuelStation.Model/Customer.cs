namespace FuelStation.Model
{
    public class Customer : Person
    {
        public string CardNumber { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
}