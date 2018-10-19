using Run_As_Chain.Model.ModelInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Model.ModelClass
{
    class ProcessingStepsModel: IProcessingStepsModel
    {
        private ObservableCollection<IMapModel> _maps;

        public ObservableCollection<IMapModel> Maps
        {
            get { return _maps; }
            //set { _maps = value; }
        }

        public void AddMap(IMapModel map)
        {
            Maps.Add(map);
        }
    }
}
