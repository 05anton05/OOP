using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class LuxuryCar : car
    {
        public override decimal GetDiscount()
        {
            return 2000;
        }
    }
}
