using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskCSADV
{
    delegate double Operation(double x, double y);
    class Calculator
    {
        public double Calculate(double x, double y, Operation op) => op(x, y);
    }

}
