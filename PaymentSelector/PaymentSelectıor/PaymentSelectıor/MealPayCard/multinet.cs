using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSelectıor.MealPayCard
{
    public class Mutlinet : PaymentManager
    {
        public override void Pay(decimal amount)
        {
            Log(amount);
            Console.WriteLine($"Mutlinet ödeme {amount} ile ödendi");
        }
    }
}
