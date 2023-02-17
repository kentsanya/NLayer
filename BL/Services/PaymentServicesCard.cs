using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    internal class PaymentServicesCard:IPaymentService
    {
        public bool Pay(decimal sum)
        {
            Console.WriteLine($"Paid {sum}");
            return true;
        }

    }
}
