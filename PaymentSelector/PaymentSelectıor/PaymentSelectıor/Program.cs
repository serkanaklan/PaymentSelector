using System;
using System.Collections.Generic;
using System;
using PaymentSelectıor;

namespace ConsoleApp;
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        MainApp app = new MainApp();
        app.app();
    }
}




