﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    internal interface IPaymentService
    {
        bool Pay(decimal sum);
    }
}
