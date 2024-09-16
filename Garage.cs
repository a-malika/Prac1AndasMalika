using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    //Класс Garage
    public class Garage
    {
        public List<Vehicle> vehicles { get; set; }
        public Garage()
        {
            vehicles = new List<Vehicle>();
        }
        public void addVehicle(Vehicle vehicle)
        {
            if (vehicles.Contains(vehicle)) 
            { 
                Console.WriteLine("Транспортное средство уже в гараже."); 
                return; 
            }
            vehicles.Add(vehicle);
            Console.WriteLine("Транспортное средство добавлено в гараж.");
        }
        public void removeVehicle(Vehicle vehicle)
        {
            if (vehicles.Remove(vehicle)) 
            { 
                Console.WriteLine("Транспортное средство убрано из гаража."); 
                return; 
            }
            Console.WriteLine("Транспортного средства нет в гараже.");
        }
    }
}
