using Calculator.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel.Algorithm
{
    public class AddViewModel:ICalculate
    {
        public double Calculate(params double[] values)
        {
            double sum = 0;
            foreach (Double val in values)
            {
                sum += val;
            }
            return sum;
        }
    }
}
