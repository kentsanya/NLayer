using BL.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    internal interface IDiscountService
    {
         public void GetValuePriceBascket(Basket basket, IDiscount discount);
    }
}
