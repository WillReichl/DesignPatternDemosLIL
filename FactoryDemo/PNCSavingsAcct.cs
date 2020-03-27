using System;
using System.Collections.Generic;
using System.Text;
using static FactoryMethod.Program;

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
