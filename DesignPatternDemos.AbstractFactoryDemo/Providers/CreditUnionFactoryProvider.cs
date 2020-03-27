using DesignPatternDemos.AbstractFactoryDemo.Factories.CitiCreditUnion;
using DesignPatternDemos.AbstractFactoryDemo.Factories.NationalCreditUnion;
using DesignPatternDemos.AbstractFactoryDemo.Interfaces;

namespace DesignPatternDemos.AbstractFactoryDemo.Providers
{
    public class CreditUnionFactoryProvider
    {
        // "Factory of Factories"
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNum)
        {
            if (accountNum.Contains("CITI"))
                return new CitiCreditUnionFactory();
            if (accountNum.Contains("NATIONAL"))
                return new NationalCreditUnionFactory();

            return null;
        }
    }
}