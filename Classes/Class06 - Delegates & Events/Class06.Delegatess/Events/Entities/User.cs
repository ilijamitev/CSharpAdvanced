using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }


        public User(string firstName, string lastName, int age, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;

        }

        public void ReadPromotion(ProductType productType, string marketName)    // metoda spored DELEGATE
        {
            Console.WriteLine($"Hello {FirstName} {LastName}, there is a promotion available for {productType} at {marketName}.");
        }



    }
}
