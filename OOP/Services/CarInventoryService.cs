using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOP.Services
{
    internal class CarInventoryService
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void RemoveCar(string model)
        {
            Console.WriteLine("Авто видалено");
        }
        public List<Car> FindCarsByBrand(string brand)
        {
            List<Car> result = new List<Car>();
            foreach (Car car in cars)
            {
                if (car.Brand == brand)
                {
                    result.Add(car);
                }
            }
            return result;
        }
        public int GetTotalValue()
        {
            int total = 0;
            foreach (Car car in cars)
            {
                total = total + car.Price;
            }
            return total;
        }
        public void ShowAll()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine( "Марка:" + car.Brand + "Модель:" + car.Model + "Вартість:" + car.Price);
            }
        }
    }
}
