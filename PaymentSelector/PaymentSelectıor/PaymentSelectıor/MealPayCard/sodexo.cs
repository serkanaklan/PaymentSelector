using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSelectıor.MealPayCard
{
public class Sodexo : PaymentManager
    {
        public override void Pay(decimal amount) {
            Log(amount);
            Console.WriteLine($"Sodexo ödemesi {amount} alındı ");
        }
    }
}
