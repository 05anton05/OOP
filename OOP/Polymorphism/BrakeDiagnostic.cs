using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    internal class BrakeDiagnostic : DiagnosticTool
    {
        public override void RunDiagnostic()
        {
            Console.WriteLine("гальмівна система в нормі");
        }
    }
}
