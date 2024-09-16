using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тестирование системы
            //Создание гаражей
            Garage garage0 = new Garage();
            Garage garage1 = new Garage();
            //Создание автопарка
            Fleet fleet = new Fleet();
            //Создание различных транспортных средств
            Vehicle vehicle0 = new Vehicle("BMW", "X5", 2010);
            Vehicle vehicle1 = new Vehicle("Toyota", "Corolla", 2020);
            Car car0 = new Car("Honda", "Accord", 2019, 4, "manual");
            Car car1 = new Car("Ford", "Focus", 2018, 5, "automatic");
            Car car2 = new Car("Audi", "A6", 2022, 4, "robotic(S-Tronic)");
            Motorcycle motorcycle0 = new Motorcycle("Yamaha", "FJR1300", 2019, "sports touring", "yes");
            Motorcycle motorcycle1 = new Motorcycle("Suzuki", "V-Strom 650", 2022, "tourenduro", "yes");
            Motorcycle motorcycle2 = new Motorcycle("Kawasaki", "Ninja 400", 2018, "sportbike", "no");
            //Проверка метода апуска и остановки двигателя
            motorcycle0.startTheEngine();
            motorcycle0.startTheEngine();
            motorcycle0.stopTheEngine();
            motorcycle1.stopTheEngine();
            //Добавление транспортных средств в гаражи
            garage0.addVehicle(vehicle0);
            garage0.addVehicle(car1);
            garage0.addVehicle(car2);
            garage0.addVehicle(motorcycle2);
            garage1.addVehicle(vehicle1);
            garage1.addVehicle(car0);
            garage1.addVehicle(motorcycle0);
            garage1.addVehicle(motorcycle1);
            //Добавление гаражей в автопарк
            fleet.addGarage(garage0);
            fleet.addGarage(garage1);
            //Проверка поиска транспортного средства, удаления гаражей и удаления транспортных средств
            Vehicle neededVehile = fleet.findVehicle("Suzuki", "V-Strom 650", 2022);
            garage1.removeVehicle(neededVehile);
            neededVehile = fleet.findVehicle("Suzuki", "V-Strom 650", 2022);
            fleet.removeGarage(garage1);
            garage0.removeVehicle(vehicle0);
            garage0.removeVehicle(vehicle1);
        }
    }
}
