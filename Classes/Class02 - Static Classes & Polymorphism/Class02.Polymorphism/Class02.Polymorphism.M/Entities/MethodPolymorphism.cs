using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.Polymorphism.M.Entities
{
    public class MethodPolymorphism
    {
        // COMPILE TIME
        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        public int AddNumbers(int first, int second, int third)
        {
            return first + second + third;
        }
        public void AddNumbers(double first, int second)
        {
            Console.WriteLine(first + second);
        }
    }
}
