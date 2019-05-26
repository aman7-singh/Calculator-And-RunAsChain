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

        void Summing(object a);
        void Minusing(object a);
        void Multiplying(object a);
        void Dividing(object a);
        void EqualTo(object a);
        void CheckEquationFlow(object a);
        void ClearAllExpression(object a);
        void PowerCalculation(object a);
        void RemainderCalculation(object a);
        void SqrtCalculation(object a);
        void PercentageCalculation(object a);
    }
}
