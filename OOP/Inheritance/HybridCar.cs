using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    internal class HybridCar : Car
    {
        public HybridCar(string brand, string model, int horsePower, double electricRange) : base(brand, model, horsePower)
          
        {
            ElectricRange = electricRange;
        }
        public double ElectricRange { get; set; }
        public void SwitchToElectricMode()
        {
            Console.WriteLine("Перехід на електро-режим");
        }
    }
}
