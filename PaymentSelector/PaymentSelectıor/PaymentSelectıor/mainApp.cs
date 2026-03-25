using PaymentSelectıor;
using System;
using System.Collections.Generic;
using System.Text;



public class  MainApp
{
    public void app()
    {
        Console.WriteLine("Ödeme grubu seçin:");
        Console.WriteLine("1 - Nakit / Kredi Kartı");
        Console.WriteLine("2 - Yemek Kartları");

        string grupSecim = Console.ReadLine();

        Console.WriteLine("Ödeme yöntemini seçin:");
        if (grupSecim == "1")
            Console.WriteLine("1 - Nakit\n2 - Kredi Kartı");
        else if (grupSecim == "2")
            Console.WriteLine("1 - Sodexo\n2 - Multinet\n3 - Edenred");


        string odemeSecim = Console.ReadLine();

        Console.Write("Ödenecek tutarı girin: ");
        decimal tutar = decimal.Parse(Console.ReadLine());

        PaymentManager odeme = PaymentFactory.CreatePayment(grupSecim, odemeSecim);

        if (odeme == null)
        {
            Console.WriteLine("Hatalı seçim");
            return;
        }

        odeme.Pay(tutar);
    }
}

