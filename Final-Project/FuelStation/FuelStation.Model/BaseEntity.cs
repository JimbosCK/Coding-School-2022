
namespace FuelStation.Model
{
    public class BaseEntity
    {
        public Guid ID { get; }
        public BaseEntity() { ID = Guid.NewGuid(); }
    }
}
