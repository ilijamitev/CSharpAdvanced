using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ClassMaterial
{
    public class Order : BaseEntity
    {
        public Product ProductName { get; set; }
        public string Address { get; set; }
        public Order()
        {

        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{ProductName} - {Address}");
        }

        // SO TO STRING OVERRIDE => Book 1 - CSharp Advanced - CSharp Advanced/
        // BEZ TO STRING OVERRIDE => Class03.ClassMaterial.Order
        public override string ToString()
        {
            return $"{ProductName} - {Address}";
        }



    }
}
