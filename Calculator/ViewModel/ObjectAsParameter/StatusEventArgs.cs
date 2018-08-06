using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel.ObjectAsParameter
{
    public class StatusEventArgs:EventArgs
    {
        public string OperationName { get; set; }
        public string OperationStatus { get; set; }
        //public StatusEventArgs(string operationName, string operationStatus)
        //{
        //    this.OperationName = operationName;
        //    this.OperationStatus = operationStatus;
        //}
    }
}
