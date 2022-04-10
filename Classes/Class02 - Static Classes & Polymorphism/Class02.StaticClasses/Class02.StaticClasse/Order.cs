using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.StaticClasse
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {

        }

        public Order(int id, string name, string description, OrderStatus orderStatus)
        {
            Id = id;
            Name = name;
            Description = description;
            Status = orderStatus;
        }

        public void Print()
        {
            Console.WriteLine($"{StringUtils.CapitaliseFirstLetter(Name)} - {StringUtils.CapitaliseFirstLetter(Description)}");
        }



    }
}
