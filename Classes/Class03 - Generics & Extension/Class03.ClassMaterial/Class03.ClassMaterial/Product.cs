using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ClassMaterial
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{Title} - {Description}.");
        }
        // SO TO STRING OVERRIDE => Book 1 - CSharp Advanced - CSharp Advanced/
        // BEZ TO STRING OVERRIDE => Class03.ClassMaterial.Order
        public override string ToString()   // ako ne se napravi ovveride se pecati i patot do klasata
        {
            return $"{Title} - {Description}";
        }

    }
}
