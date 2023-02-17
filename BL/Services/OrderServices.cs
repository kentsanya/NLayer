using BL.BusinessModels;
using BL.Interfaces;
using DataLayer.Repositories;

namespace BL.Services
{
    internal class OrderServices : IOrderServices
    {
        IUnitOfWork DB { get; }
        IDiscount discount;
        public OrderServices(IUnitOfWork unit, IDiscount discount) 
        {   
            this.discount = discount;
            DB= unit;
        }
      

        void IOrderServices.MakeOrder(Basket basket, IDelivaryServices delivary,
            IDiscountService discountservice, IPaymentService payment)
        {
            if (basket != null)
            {
                discountservice.GetValuePriceBascket(basket, discount);
                if (payment.Pay(basket.SumPrice))
                {
                    delivary.Delivary();
                }
                else throw new Exception("Pay wasn`t done");
            }
            else throw new Exception("Basket was empty");
            
        }
    }
}
