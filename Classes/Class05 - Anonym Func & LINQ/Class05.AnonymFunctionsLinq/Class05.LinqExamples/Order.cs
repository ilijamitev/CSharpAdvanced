using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.LinqExamples
{

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {

        }

        public override string ToString()   // za da se zemat kako string site propertinja fo objektot
        {
            return $"ID {Id}. Name {Name}. Quantity {Quantity}. OrderStatus {Status}.";
        }
    }
}
