using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Models;

namespace TimeTracking.Data
{
    public static class ModelsDatabase
    {
        public static List<User> UsersList { get; set; } = new List<User>()
        {
            new("Ilija", "Mitev", 26, "ilija", "Ilija1")
        };




    }
}
