using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSelectıor.NormalPayment
{
   public class CreditCard : PaymentManager
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"kredi kartı ödeemesi {amount}");
        }
    }
}
