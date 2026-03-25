using PaymentSelectıor.MealPayCard;
using PaymentSelectıor.NormalPayment;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSelectıor
{
    public static class PaymentFactory
    {
        private static readonly Dictionary<string, PaymentManager> paymentMap = new Dictionary<string, PaymentManager>()
        {
            { "1-1", new CashPayment() },
            { "1-2", new CreditCard() },
            { "2-1", new Sodexo() },
            { "2-2", new Mutlinet() },
            { "2-3", new EdenRed() }
        };

        public static PaymentManager CreatePayment(string group, string name)
        {
            string key = $"{group}-{name}";
            if (paymentMap.ContainsKey(key))
                return paymentMap[key];
            return null;
        }
    }
}

