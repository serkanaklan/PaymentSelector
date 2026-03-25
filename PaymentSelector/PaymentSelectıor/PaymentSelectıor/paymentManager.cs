using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSelectıor
{
    public abstract class PaymentManager : IPayment
    {
        public abstract void Pay(decimal amount);

        public void Log(decimal amount)
        {
            Console.WriteLine($"Ödeme tutarı: {amount}");
        }
    }
}
