﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Division: ICalculator
    {
        public double DoCalc(double a, double b)
        {
          
            return a/b;
          
        }
    }
}
