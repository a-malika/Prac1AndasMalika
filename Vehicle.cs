using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    //Класс Vehicle
    public class Vehicle
    {
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int YearOfManufacture { get; set; }
        private string StatusOfVehicle { get; set; } = "off";
        public Vehicle(string vehicleMake, string vehicleModel, int yearOfManufacture)
        {
            VehicleMake = vehicleMake;
            VehicleModel = vehicleModel;
            YearOfManufacture = yearOfManufacture;
        }
        public void startTheEngine()
        {
            if (StatusOfVehicle == "on")
            {
                Console.WriteLine("Двигатель уже запущен.");
                return;
            }
            Console.WriteLine("Запускаем двигатель.");
            StatusOfVehicle = "on";
        }
        public void stopTheEngine()
        {
            if (StatusOfVehicle == "off")
            {
                Console.WriteLine("Двигатель уже выключен.");
                return;
            }
            Console.WriteLine("Выключаем двигатель.");
            StatusOfVehicle = "off";
        }
    }
}
