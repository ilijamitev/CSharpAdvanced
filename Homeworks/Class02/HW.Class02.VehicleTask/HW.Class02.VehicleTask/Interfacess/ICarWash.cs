using HW.Class02.VehicleTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Class02.VehicleTask.Interfacess
{
    public interface ICarWash
    {
        void WashCar(Car car);
        void WashTrailer(Truck truck);
    }
}
