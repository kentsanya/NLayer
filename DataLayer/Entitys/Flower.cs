using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entitys
{
    public abstract class Flower
    {
        internal int Id { get; set; }
        internal string Name { get; set; }

        internal Price Price { get; set; }
        
    }
}
