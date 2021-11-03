using System;
using BankTellerApp.Models;

namespace BankTellerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankTeller wemaTeller = new BankTeller();
            Console.WriteLine(wemaTeller.ShowCummulativeInterest());
        }
    }
}
