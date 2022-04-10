using HW.Class02.VehicleTask.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Class02.VehicleTask.Interfacess
{
    public interface IRepairService
    {
        bool CheckVehicle(Vehicle vehicle);
        void FixVehicle(Vehicle vehicle);

    }
}
