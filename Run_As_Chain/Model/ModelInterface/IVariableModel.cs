using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelInterface
{
    interface IVariableModel
    {
        string Value { get; }
        string IsPublic { get; }
        string InitialValue { get; }
    }
}
