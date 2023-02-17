using BL.DTOModels;
using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BusinessModels
{
    internal class DiscountCustomer:IDiscount
    {

        internal int Id { get; set; }
        internal decimal Value { get; set; }
        internal CustomerDTO  Customer { get; set; }

        public decimal GetDiscount()
        {
           return Value;
        }
    }
}
