using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.StaticClasse
{
    public class User
    {
        public static int UserCount { get; set; } = 0;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Order> Orders { get; set; }

        public User(int id, string name, string lastName)
        {
            Id = id;
            FirstName = name;
            LastName = lastName;
            UserCount++;
            Orders = new List<Order>();
        }


        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} The number of users is {UserCount}");
        }

        public static void PrintUserCount()
        {
            Console.WriteLine($"Number of created users: {UserCount}");
        }

        public void PrintOrders()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            foreach (Order order in Orders)
            {
                order.Print();
            }
        }





    }
}
