using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    internal class EngineDiagnostic : DiagnosticTool
    {
        public override void RunDiagnostic()
        {
            Console.WriteLine("Двигун працює коректно");
        }
    }
}
