using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");

            Console.WriteLine($"My citi balance is ${citiAcct.Balance}" +
                $" and national balance is ${nationalAcct.Balance}");
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
        interface ICreditUnionFactory
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

                throw new ArgumentException("Invalid Account Number");
            }
        }
    }
}
