using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Employee : Person
    {
        public int WorkHours { get; set; }

        public Employee(int id, string name, string lastName, int workHours) : base(id, name, lastName)  //nasleduva od base konstruktorot  
        {
            //Id = id;  nema vaka  tuku ke go povikame base konstruktorot (KONSTRUKTOROT OD KLASATA STO NASLEDUVA OVAA KLASA)
            WorkHours = workHours;
        }



        public override string GetInfo()
        {
            return $"{Name} {LastName} works hours are {WorkHours}.";
        }





    }
}
