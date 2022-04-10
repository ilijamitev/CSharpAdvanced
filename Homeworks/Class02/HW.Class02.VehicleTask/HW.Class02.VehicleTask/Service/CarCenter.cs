using HW.Class02.VehicleTask.BaseModel;
using HW.Class02.VehicleTask.Interfacess;
using HW.Class02.VehicleTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Class02.VehicleTask.Service
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public bool CheckVehicle(Vehicle vehicle)
        {
            return vehicle.IsBroken;
        }

        public void FixVehicle(Vehicle vehicle)
        {
            if (vehicle.IsBroken)
            {
                Console.WriteLine($"{vehicle.Owner} your vehicle is now repaired. We didn't take any part, promise :D.");
                vehicle.IsBroken = false;
            }
            else
            {
                Console.WriteLine($"{vehicle.Owner} your vehicle is fine :).");
            }
        }

        public void PumpGas(Vehicle vehicle)
        {
            if (vehicle.EmptyTank)
            {
                Console.WriteLine($"{vehicle.Owner} your tank is now full.");
                vehicle.EmptyTank = false;
            }
            else
            {
                Console.WriteLine($"{vehicle.Owner} your tank is already full.");
            }
        }

        public void WashCar(Car car)
        {
            if (!car.IsWashed)
            {
                Console.WriteLine($"{car.Owner} your Car is now clean.");
                car.IsWashed = true;
            }
            else
            {
                Console.WriteLine($"{car.Owner} your Car is already clean.");
            }
        }

        public void WashTrailer(Truck truck)
        {
            if (!truck.IsWashed)
            {
                Console.WriteLine($"{truck.Owner} your Truck is now clean.");
                truck.IsWashed = true;
            }
            else
            {
                Console.WriteLine($"{truck.Owner} your Truck is already clean.");
            }
        }
    }
}
