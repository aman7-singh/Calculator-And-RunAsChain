using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel.Interfaces
{
    public interface ICalculate
    {
        double Calculate(params double[] values);
    }
}
