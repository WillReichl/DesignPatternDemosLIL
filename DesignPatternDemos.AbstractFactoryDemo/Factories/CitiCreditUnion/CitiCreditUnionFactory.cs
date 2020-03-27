using DesignPatternDemos.AbstractFactoryDemo.Factories.CitiCreditUnion.Accounts;
using DesignPatternDemos.AbstractFactoryDemo.Interfaces;

namespace DesignPatternDemos.AbstractFactoryDemo.Factories.CitiCreditUnion
{
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            var loanAccount = new CitiLoanAccount();
            return loanAccount;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            var savingsAccount = new CitiSavingsAccount();
            return savingsAccount;
        }
    }
}