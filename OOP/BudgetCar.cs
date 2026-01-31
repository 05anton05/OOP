using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class BudgetCar : car
    {
        public override decimal GetDiscount()
        {
            return 300;
        }
    }
}

