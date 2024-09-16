using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    //Класс Car
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public string TransmissionType { get; set; }
        public Car(string vehicleMake, string vehicleModel, int yearOfManufacture, int numberOfDoors, string transmissionType) : base(vehicleMake, vehicleModel, yearOfManufacture)
        {
            NumberOfDoors = numberOfDoors;
            TransmissionType = transmissionType;
        }
    }
}
