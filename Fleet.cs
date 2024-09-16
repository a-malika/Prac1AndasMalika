using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    //Класс Fleet
    public class Fleet
    {
        public List<Garage> fleet {  get; set; }
        public Fleet()
        {
            fleet = new List<Garage>();
        }
        public void addGarage(Garage garage)
        {
            if (fleet.Contains(garage)) 
            { 
                Console.WriteLine("Гараж уже добавлен в автопарк."); 
                return; 
            }
            fleet.Add(garage);
            Console.WriteLine("Гараж добавлен в автопарк");
        }
        public void removeGarage(Garage garage)
        {
            if (fleet.Remove(garage)) 
            { 
                Console.WriteLine("Гараж удален из автопарка."); 
                return; 
            }
            Console.WriteLine("Гараж не является частью автопарка.");
        }
        public Vehicle findVehicle(string vehicleMake, string vehicleModel, int yearOfManufacture)
        {
            foreach (Garage garage in fleet)
            {
                foreach (Vehicle vehicle in garage.vehicles)
                {
                    if (vehicle.VehicleMake == vehicleMake && vehicle.VehicleModel == vehicleModel && vehicle.YearOfManufacture == yearOfManufacture)
                    {
                        Console.WriteLine("Транспортное средство найдено.");
                        return vehicle;
                    }
                }
            }
            Console.WriteLine("Транспортное средство не было найдено.");
            return null;
        }
    }
}
