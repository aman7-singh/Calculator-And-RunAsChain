using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Transformations
{
    public class TransformationViewModel
    {
        List<string> p = new List<string>();
        public List<string> tran { get; set; }
        public TransformationViewModel(string path)
        {
            
            p.Add(path);
            tran = p;
        }
    }
}
