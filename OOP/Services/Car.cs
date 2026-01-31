using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Services
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public Car(string brand, string model, int price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
    }
}
