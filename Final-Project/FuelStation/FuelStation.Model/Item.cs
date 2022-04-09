
namespace FuelStation.Model
{
    public class Item
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }
}
