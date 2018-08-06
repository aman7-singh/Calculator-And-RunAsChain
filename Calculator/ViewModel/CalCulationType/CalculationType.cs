//using Calculator.ViewModel.Addition;
using Calculator.ViewModel.Algorithm;
using Calculator.ViewModel.Interfaces;
using Calculator.ViewModel.Subtraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel.CalCulationType
{
    public static class CalculationType
    {
        public static ICalculate OperationType(object sign)
        {
            ICalculate Operation = null;
            switch (sign)
            {
                case "+":
                    Operation = new AddViewModel();
                    break;
                case "-":
                    Operation = new SubtractionViewModel();
                    break;
                case "*":
                    Operation = new MultiplicationViewodel();
                    break;
                case "/":
                    Operation = new DivideVieModel();
                    break;
                case "^":
                    Operation = new PowerViewModel();
                    break;
                case "%":
                    Operation = new PercentageViewModel();
                    break;
                case "\\":
                    Operation = new SqrtViewModel();
                    break;
                case "r":
                    Operation = new RemainderViewModel();
                    break;
                default:
                    throw new NotImplementedException("Not Implemented Yet");
            }
            return Operation;
        }
    }
}
