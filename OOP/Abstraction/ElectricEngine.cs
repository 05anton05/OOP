using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction
{
    internal class ElectricEngine : Engine
    {
        public ElectricEngine(int horsePower) : base(horsePower) { }
        public override void Start()
        {
            Console.WriteLine($"Батарею запущено! \nПотужність: {HorsePower} (к.с)");
        }
    }
}
