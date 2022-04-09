
namespace FuelStation.Model
{
    public class Item : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        //Relations
        public List<TransactionLine> TransactionLines { get; set; } = new();

    }
}
