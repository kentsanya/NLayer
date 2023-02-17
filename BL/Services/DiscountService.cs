using BL.BusinessModels;
using BL.Interfaces;

namespace BL.Services
{
    internal class DiscountService : IDiscountService
    {
        public void GetValuePriceBascket(Basket basket, Interfaces.IDiscount discount)
        {
            basket.SumPrice = basket.SumPrice * discount.Value();
        }
    }
}
