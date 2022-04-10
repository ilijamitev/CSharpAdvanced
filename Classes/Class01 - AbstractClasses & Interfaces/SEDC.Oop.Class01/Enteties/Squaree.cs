using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Squaree : Figuress
    {
        public int Side { get; set; }
        public Squaree(int side)
        {
            Side = side;
        }
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
}
