using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Virtual.Override
{
    internal class BudgetCar : car
    {
        public override decimal GetDiscount()
        {
            return 300;
        }
    }
}

