using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; } 

        public ElectricCar(string brand, string model, int horsePower, int batteryCapacity) : base(brand, model, horsePower)
        {
            BatteryCapacity = batteryCapacity;
        }
        public void ChargeBattery()
        {
            Console.WriteLine("Автомобіль заряджається");
        }
    }
}
