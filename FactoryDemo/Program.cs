using FactoryDemo;
using System;

namespace DesignPatternDemos.FactoryDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");
            var pncAcct = factory.GetSavingsAccount("PNC-456");

            Console.WriteLine($"My citi balance is ${citiAcct.Balance}" +
                $" and national balance is ${nationalAcct.Balance}");

            Console.WriteLine($"Also, my PNC account balance is ${pncAcct.Balance}.");
        }

        // Product
        public abstract class ISavingsAccount
        {
            public decimal Balance { get; set; }
        }

        // Concrete Product
        public class CitiSavingsAcct : ISavingsAccount
        {
            public CitiSavingsAcct()
            {
                Balance = 5000;
            }
        }

        // Concrete Product
        public class NationalSavingsAcct : ISavingsAccount
        {
            public NationalSavingsAcct()
            {
                Balance = 2000;
            }
        }

        // Creator
        private interface ICreditUnionFactory
        {
            ISavingsAccount GetSavingsAccount(string acctNo);
        }

        // Concrete Creators
        public class SavingsAcctFactory : ICreditUnionFactory
        {
            public ISavingsAccount GetSavingsAccount(string acctNo)
            {
                if (acctNo.Contains("CITI"))
                    return new CitiSavingsAcct();

                if (acctNo.Contains("NATIONAL"))
                    return new NationalSavingsAcct();

                if (acctNo.Contains("PNC"))
                    return new PNCSavingsAcct();

                throw new ArgumentException("Invalid Account Number");
            }
        }
    }
}