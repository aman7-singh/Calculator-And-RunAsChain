using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel.Interfaces
{
    public interface IStandardViewModel
    {
        string Expression { get; set; }
        string Operation { get; set; }
        double CalcultedValue { get; set; }
    }
}
