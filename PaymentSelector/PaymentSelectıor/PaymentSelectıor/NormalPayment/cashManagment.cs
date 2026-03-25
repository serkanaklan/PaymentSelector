using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSelectıor.NormalPayment
{
   public class CashPayment :  PaymentManager {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"nakit ödeme {amount} alındı");
        }
    }
}
