using BL.BusinessModels;
using BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IOrderServices
    {

        internal void MakeOrder(Basket basket, IDelivaryServices delivary,
            IDiscountService discount,  IPaymentService payment);

    }
}
