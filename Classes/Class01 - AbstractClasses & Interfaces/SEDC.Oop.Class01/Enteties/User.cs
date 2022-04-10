using Enteties.Interfacees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class User : IUsers
    {
        public int Id { get; set; }
        public User(int id)
        {
            Id = id;
        }

        public string GetId()
        {
            return Id.ToString();
        }
    }
}
