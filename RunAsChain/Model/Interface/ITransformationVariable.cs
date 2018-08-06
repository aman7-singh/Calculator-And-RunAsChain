using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.Model.Interface
{
    public interface ITransformationVariable
    {
        string TVariable { get; set; }
        bool IsPublic { get; set; }
        string InitialValue { get; set; }
    }
}
