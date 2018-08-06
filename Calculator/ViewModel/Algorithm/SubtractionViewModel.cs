using Calculator.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel.Subtraction
{
    public class SubtractionViewModel:ICalculate
    {
        public double Calculate(params double[] values)
        {
            if (values[0]==0)
            {
                return values[1];
            }
            else
            return values[0] - values[1];
        }
    }
}
