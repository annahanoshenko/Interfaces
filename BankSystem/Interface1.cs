﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
    
    
}
