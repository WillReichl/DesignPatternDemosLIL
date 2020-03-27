using DesignPatternDemos.AbstractFactoryDemo.Interfaces;
using System;

namespace DesignPatternDemos.AbstractFactoryDemo.Factories.CitiCreditUnion.Accounts
{
    public class CitiLoanAccount : ILoanAccount
    {
        public CitiLoanAccount()
        {
            Console.WriteLine("Returned Citi Loan Account");
        }
    }
}