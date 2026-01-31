using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    internal class DiagnosticTool
    {
        public virtual void RunDiagnostic()
        {
            Console.WriteLine("Запуск ситеми діагностування");
        }
    }
}
