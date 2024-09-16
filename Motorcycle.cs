using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    //Класс Motorcycle
    public class Motorcycle : Vehicle
    {
        public string BodyType { get; set; }
        public string PresenceOfBoxing { get; set; }
        public Motorcycle(string vehicleMake, string vehicleModel, int yearOfManufacture, string bodyType, string presenceOfBoxing) : base(vehicleMake, vehicleModel, yearOfManufacture)
        {
            BodyType = bodyType;
            PresenceOfBoxing = presenceOfBoxing;
        }
    }
}
