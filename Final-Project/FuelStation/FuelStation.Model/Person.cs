
namespace FuelStation.Model
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get { return $"{Name} {Surname}"; } }
    }
}
