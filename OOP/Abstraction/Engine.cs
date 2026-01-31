using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction
{
    internal abstract class Engine
    {
        public int HorsePower { get; }
        protected Engine(int horsePower)
        {
            HorsePower = horsePower;
        }

        public abstract void Start();
        public void Stop()
        {
            Console.WriteLine("Двигун зупинено!");
        }
    }
}
