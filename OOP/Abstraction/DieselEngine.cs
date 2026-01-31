using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction
{
    internal class DieselEngine : Engine
    {
        public DieselEngine(int horsePower) : base(horsePower) { }
        public override void Start()
        {
            Console.WriteLine($"Дизельний двигун запущено! \nПотужність: {HorsePower} (к.с)");
        }
    }
}
