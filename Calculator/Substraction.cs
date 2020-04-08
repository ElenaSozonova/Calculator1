using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Substraction: ICalculator
    {
        public double DoCalc(double a, double b)
        {
            double c = a - b;
            return c;
        }
    }
}
