using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction
{
    internal class PetrolEngine : Engine
    {
        public PetrolEngine(int horsePower) : base(horsePower) { }
           
        public override void Start()
        {
            Console.WriteLine($"Бензиновий двигун  запущено! \nПотужність: {HorsePower} (к.с)");
        }
    }
}
