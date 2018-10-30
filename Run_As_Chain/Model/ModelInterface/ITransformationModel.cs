using Run_As_Chain.Model.ModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelInterface
{
    interface ITransformationModel
    {
        string CreatedOn { get; }
        string CreatedBy { get; }
        ProcessingStepsModel ProcessingStepsModel { get; }
    }
}
