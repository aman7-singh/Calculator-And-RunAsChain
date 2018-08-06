using RunAsChain.ViewModel.Command;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.Delegate;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        public MenuViewModel()
        {
            IMenuMethod method = new MenuMethods();
            NewCommand = new RelayCommand(method.CreateNewChain);
            OpenCommand = new RelayCommand(method.OpenChain);
            SaveCommand = new RelayCommand(method.SaveChain);
            SaveAsCommand = new RelayCommand(method.SaveAsChain);
            RunCommand = new RelayCommand(method.RunChain);
            RunAllCommand = new RelayCommand(method.RunAllChain);
        }

        public ICommand OpenCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand SaveAsCommand { get; set; }
        public ICommand NewCommand { get; set; }
        public ICommand RunCommand { get; set; }
        public ICommand RunAllCommand { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string Property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Property));
            }
        }
    }
}
