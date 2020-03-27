using DesignPatternDemos.AbstractFactoryDemo.Interfaces;
using System;

namespace DesignPatternDemos.AbstractFactoryDemo.Factories.NationalCreditUnion.Accounts
{
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Console.WriteLine("Returned National Savings Account");
        }
    }
}