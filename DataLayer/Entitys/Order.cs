using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entitys
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Delivary Delivary { get; set; }
        public ICollection<Flower> Flowers { get; set; }
        public int CustomerId { get; set; }
        public int AdressCustomerId { get; set; }
    }
}
