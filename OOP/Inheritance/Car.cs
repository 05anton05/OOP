using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public void ShowInfo()
        {
           Console.WriteLine($"\nМодель: {Model} \nКінські сили: {HorsePower} \nМодель^ {Model}");
        }


    }
}
