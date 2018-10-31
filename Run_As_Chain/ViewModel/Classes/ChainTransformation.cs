using Run_As_Chain.Model;
using Run_As_Chain.Model.ModelInterface;
using Run_As_Chain.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.ViewModel.Classes
{
    public class ChainTransformation:IChainTransformation
    {
        private ITransformationModel _chainObj;

        public ITransformationModel ChainObj
        {
            get { return _chainObj; }
        }
        ModelObjectBuilder ObjectBuilder = new ModelObjectBuilder();

        public void loadChain(string path)
        {
            _chainObj = ObjectBuilder.XmlToObject(path);
        }
    }
}
