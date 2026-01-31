using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    internal class DieselCar : Car
    {
        public int FuelConsumption { get; set; }

        public DieselCar(string brand, string model, int horsePower, int fuelConsumption) : base(brand, model, horsePower)

        {
            FuelConsumption = fuelConsumption;
        }

        public void Refuel()
        {
            Console.WriteLine("Дизель заправляється");
        }
    }
}
