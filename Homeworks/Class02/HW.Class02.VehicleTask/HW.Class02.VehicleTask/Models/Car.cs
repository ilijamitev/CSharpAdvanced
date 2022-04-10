using HW.Class02.VehicleTask.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Class02.VehicleTask.Models
{
    public class Car : Vehicle
    {
        public Car(string owner, string model, int year, bool isBroken = false) : base(owner, model, year, isBroken)
        {
        }

        public override void Drive()
        {
            if (IsBroken)
            {
                Console.WriteLine($"{Owner} you can't drive with broken car. Go fix it.");
            }
            else if (EmptyTank)
            {
                Console.WriteLine($"{Owner} you can't drive with an empty tank :)");
            }
            else
            {
                Console.WriteLine($"{Owner} is now driving a Car {Model} from {Year}.");
            }
        }
    }
}
