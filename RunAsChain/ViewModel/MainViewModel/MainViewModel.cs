using RunAsChain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            XmlToObjectBuilder x = new XmlToObjectBuilder();
            var ChainObject = x.ModelObj();
        }
    }
}
