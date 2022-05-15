using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalculatorApp
{
    internal interface ICalculator
    {
        void AddOperation(Operation op, Func<int, int, int> function);
        int Execute(int first, int second, Operation op);
        Operation Resolve(string symbol);
    }

    
}
