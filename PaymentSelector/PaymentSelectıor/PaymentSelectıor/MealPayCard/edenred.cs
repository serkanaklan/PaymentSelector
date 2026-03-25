using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSelectıor.MealPayCard
{
    public class EdenRed : PaymentManager
    {
        public override void Pay(decimal amount)
        {
            Log(amount);
            Console.WriteLine($"Edenred ödeme {amount} ile ödendi");
        }
    }
}
