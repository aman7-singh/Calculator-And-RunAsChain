using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu
{
    public class Notify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(object sender, string Property)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(sender, new PropertyChangedEventArgs(Property));
            }
        }
    }
}
