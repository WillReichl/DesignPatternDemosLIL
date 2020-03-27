namespace DesignPatternDemos.AbstractFactoryDemo.Interfaces
{
    public abstract class ICreditUnionFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();

        public abstract ILoanAccount CreateLoanAccount();
    }
}