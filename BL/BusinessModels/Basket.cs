using BL.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BusinessModels
{
    internal class Basket
    {
        public int Id { get; set; }
        public ICollection<FlowerDTO> Flowers { get; set; }
        public CustomerDTO Customer { get; set; }

        public decimal SumPrice
        {
            get
            {
                decimal sum = 0;
                foreach (var flower in Flowers)
                {
                    sum += flower.Price.Value;
                }
                return sum;
            }
            set 
            {
                SumPrice=value;
            }
        }
    }
}
