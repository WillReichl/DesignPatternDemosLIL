using static DesignPatternDemos.FactoryDemo.Program;

namespace FactoryDemo
{
    public class PNCSavingsAcct : ISavingsAccount
    {
        public PNCSavingsAcct()
        {
            Balance = 3000;
        }
    }
}