using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    internal class Dashboard
    {

        private int speed;
        private int fuelLevel;
        private int engineTemperature;

        public Dashboard()
        {
            speed = 0;
            fuelLevel = 0;
            engineTemperature = 0;
        }
        public void Accelerate(int amount)
        {
            if (amount > 260)
            {
                Console.WriteLine("Швидкість занадто висока!");
                return;
            }
            speed = amount;
        }
        public void Brake(int amount)
        {
            // speed = 50
            if (amount < 0)
            {
                Console.WriteLine("Помилка зупинки, зупиніть автомобіль!");
                speed = 0;
                return;
            }
            speed = amount;
        }
        public void Refuel(int liters)
        {
            while (liters >= 0 || fuelLevel <= 60)
            {
                fuelLevel++;
                liters--;
            }
            Console.WriteLine("Запраку завершенно!");
            
        }
        public void CoolEngine(int degrees)
        {
            const int workTemperature = 90;
            while (degrees > 0 || degrees < 130 || engineTemperature != workTemperature)
            {
                engineTemperature--;
                
            }
            Console.WriteLine("охолодження завершено!");
        }
        public void ShowStatus()
        {
            Console.WriteLine($"Швидкість: {speed} \nКількість палива: {fuelLevel} \n Тумпература масла в двигуні: {engineTemperature}");
        }


    }
}

