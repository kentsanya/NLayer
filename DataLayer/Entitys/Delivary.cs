
namespace DataLayer.Entitys
{
    public class Delivary
    {
        internal int Id { get; set; }
        public string Name { get; set; }
        public AdressCustomer? ToAdress { get; set; }
        public DateOnly DateShip { get; set; } 
    }
}
