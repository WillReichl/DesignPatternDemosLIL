using DesignPatternDemos.AbstractFactoryDemo.Factories.NationalCreditUnion.Accounts;
using DesignPatternDemos.AbstractFactoryDemo.Interfaces;

namespace DesignPatternDemos.AbstractFactoryDemo.Factories.NationalCreditUnion
{
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            var loanAccount = new NationalLoanAccount();
            return loanAccount;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            var savingsAccount = new NationalSavingsAccount();
            return savingsAccount;
        }
    }
}