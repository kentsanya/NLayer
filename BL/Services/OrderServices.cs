using BL.BusinessModels;
using BL.Interfaces;
using DataLayer.Repositories;

namespace BL.Services
{
    internal class OrderServices : IOrderServices
    {
        IUnitOfWork DB { get; }
        public OrderServices(IUnitOfWork unit) 
        {
            DB= unit;
        }
      

        void IOrderServices.MakeOrder(Basket basket, IDelivaryServices delivary, IDiscountService discount, IPaymentService payment)
        {
            if (basket != null) 
            {
                discount.GetValuePriceBascket(basket, )
            }
            if(payment.Pay(discount.GetValuePriceBascket())
        }
    }
}
