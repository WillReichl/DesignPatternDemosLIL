using DesignPatternDemos.AbstractFactoryDemo.Interfaces;
using System;

namespace DesignPatternDemos.AbstractFactoryDemo.Factories.CitiCreditUnion.Accounts
{
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Console.WriteLine("Returned Citi Savings Account");
        }
    }
}