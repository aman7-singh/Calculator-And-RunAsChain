using RunAsChain.Model;
using RunAsChain.Model.Interface;
using RunAsChain.Model.Map;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.Delegate;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.Interface;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Tab;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Transformations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu
{
    public class MenuMethods: Notify, IMenuMethod
    {
        MenuArgs args = new MenuArgs();
        private ObservableCollection<string> _chainList =new ObservableCollection<string>();
        public ObservableCollection<string> ChainList
        {
            get { return _chainList; }
            set
            {
                _chainList = value;
                RaisePropertyChanged(this, "ChainList");
            }
        }
        private ObservableCollection<IMap> _MapList = new ObservableCollection<IMap>();
        public ObservableCollection<IMap> MapList
        {
            get { return _MapList; }
            set
            {
                _MapList = value;
                RaisePropertyChanged(this,"MapList");
            }
        }
        private ObservableCollection<ICodeModules> _basList = new ObservableCollection<ICodeModules>();
        public ObservableCollection<ICodeModules> BasList
        {
            get { return _basList; }
            set
            {
                _basList = value;
                RaisePropertyChanged(this, "BasList");
            }
        }
        public MenuMethods()
        {

        }
        public void CreateNewChain(object obj)
        {            
            args.SelectedItem = "Done";
                OnMethodChanged(this, args);
        }

        public void OpenChain(object obj)
        {
        }

        public void RunAllChain(object obj)
        {
            //throw new NotImplementedException();
        }

        public void RunChain(object obj)
        {
            //throw new NotImplementedException();
        }

        public void SaveAsChain(object obj)
        {
            var args = new MenuArgs();
            args.SelectedItem = "asd";
            MethodChanged(obj, args);
            //throw new NotImplementedException();
        }

        public void SaveChain(object obj)
        {
            //throw new NotImplementedException();
        }

        public event MethodeToTrigger MethodChanged;
        public void OnMethodChanged(object sender, MenuArgs e)
        {
            if (MethodChanged != null)
            {
                MessageBox.Show(sender + " : " + e.SelectedItem);
            }
        }
    }
}
