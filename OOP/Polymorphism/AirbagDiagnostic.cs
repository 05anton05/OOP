using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    internal class AirbagDiagnostic : DiagnosticTool
    {
        public override void RunDiagnostic()
        {
            Console.WriteLine("Подушки безпеки не пошкодженні!");
        }

    }
}
