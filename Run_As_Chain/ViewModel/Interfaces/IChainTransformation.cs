using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.ViewModel.Interfaces
{
    interface IChainTransformation
    {
        ITransformationModel ChainObj { get; }

    }
}
