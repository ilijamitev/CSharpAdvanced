using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Class02.VehicleTask.BaseModel
{
    public abstract class Vehicle
    {
        public string Owner { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsMoving { get; set; }
        public bool IsBroken { get; set; }
        public bool EmptyTank { get; set; }
        public bool IsWashed { get; set; }
        public Vehicle(string owner, string model, int year, bool isBroken = false)
        {
            Owner = owner;
            Model = model;
            Year = year;
            IsBroken = isBroken;
            IsMoving = false;
            EmptyTank = true;
            IsWashed = false;
        }

        public abstract void Drive();
    }
}
