using DesignPatternDemos.AbstractFactoryDemo.Interfaces;
using System;

namespace DesignPatternDemos.AbstractFactoryDemo.Factories.NationalCreditUnion.Accounts
{
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("Returned National Loan Account");
        }
    }
}