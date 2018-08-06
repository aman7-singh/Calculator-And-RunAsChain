using RunAsChain.Model;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.Delegate;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu
{
    public class MenuMethods: IMenuMethod
    {
        MenuArgs args = new MenuArgs();
        public MenuMethods()
        {
            MethodChanged += OnMethodChanged;
        }
        public void CreateNewChain(object obj)
        {            
            args.SelectedItem = "Done";
                OnMethodChanged(this, args);
        }

        public void OpenChain(object obj)
        {
            XmlToObjectBuilder x = new XmlToObjectBuilder();
            x.ModelObj();

            //throw new NotImplementedException();
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
