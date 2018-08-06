using Calculator.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel.Algorithm
{
     class MultiplicationViewodel: ICalculate
    {
        public double Calculate(params double[] values)
        {
            double multi = 1;
            foreach (Double val in values)
            {
                multi *= val;
            }
            return multi;
        }
    }
}
