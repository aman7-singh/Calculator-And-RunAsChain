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
        private ObservableCollection<IMapModel> _maps =new ObservableCollection<IMapModel>();

        public ObservableCollection<IMapModel> Maps
        {
            get { return _maps; }
        }

        public void AddMap(IMapModel map)
        {
            Maps.Add(map);
        }
        private XmlEnum _elementName;
        public ProcessingStepsModel(XmlEnum elementName)
        {
            _elementName = elementName;
        }
    }
}
