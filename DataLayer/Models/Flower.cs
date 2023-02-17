using DataLayer.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOModels
{
    public abstract class Flower
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string NameColor { get; set; } 
        internal Image Image { get; set; }  
        
    }
}
