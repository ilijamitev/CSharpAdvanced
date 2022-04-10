// See https://aka.ms/new-console-template for more information
using HW.Class02.VehicleTask.BaseModel;
using HW.Class02.VehicleTask.Models;
using HW.Class02.VehicleTask.Service;

Console.Title = "       CAR CENTER";

Car vehicle1 = new Car("Pink Panther", "Toyota Corolla", 2013, true);
Truck vehicle2 = new Truck("Micky Mouse", "Ford Grand", 2015, true);
Truck vehicle3 = new Truck("Charlie Chaplin", "Jeep", 2010);
Car vehicle4 = new Car("Pluto", "Alfa Romeo", 2013, true);    //it's not Alfa for no-reason :D.

CarCenter carCenter = new CarCenter();

carCenter.PumpGas(vehicle1);
vehicle1.Drive();
carCenter.CheckVehicle(vehicle1);
carCenter.FixVehicle(vehicle1);
vehicle1.Drive();
carCenter.FixVehicle(vehicle1);
carCenter.WashCar(vehicle1);
carCenter.WashCar(vehicle1);

Console.WriteLine("=========================");

vehicle2.Drive();
carCenter.WashTrailer(vehicle2);
carCenter.FixVehicle(vehicle2);
vehicle2.Drive();
carCenter.PumpGas(vehicle2);
vehicle2.Drive();
carCenter.WashTrailer(vehicle2);

Console.ReadLine();