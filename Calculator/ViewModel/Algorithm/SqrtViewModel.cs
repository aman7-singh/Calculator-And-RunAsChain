using Calculator.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel.Algorithm
{
    public class SqrtViewModel : ICalculate
    {
        public double Calculate(params double[] values)
        {
            return Math.Sqrt(values[0]);
        }
    }
}
