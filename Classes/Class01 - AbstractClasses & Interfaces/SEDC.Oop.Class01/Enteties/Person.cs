using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
        //abstract public string GetInfo()   // VAKA NEMOZE BIDEJKI E ABSTRACT METODA
        //{

        //}
        abstract public string GetInfo();

        public void GetDescription()            // Vaka moze..
        {
            Console.WriteLine("This is a person.");
        }


    }
}
