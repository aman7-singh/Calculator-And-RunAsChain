﻿using Calculator.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel.Algorithm
{
    public class RemainderViewModel : ICalculate
    {
        public double Calculate(params double[] values)
        {
            return values[0] % values[1];
        }
    }
}
