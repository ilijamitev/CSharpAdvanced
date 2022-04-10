using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.StaticClasse
{
    public static class FirstStaticClass
    {
        public static int Counter { get; set; }

        static FirstStaticClass()
        {
            Counter = 1;
        }

        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }




    }
}
