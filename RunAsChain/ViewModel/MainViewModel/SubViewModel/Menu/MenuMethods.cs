using RunAsChain.Model;
using RunAsChain.Model.Interface;
using RunAsChain.Model.Map;
using RunAsChain.ViewModel.Command;
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
using System.Windows.Input;
using System.Xml.Linq;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu
{
    public class MenuMethods: Notify, IMenuMethod
    {
        public MenuMethods()
        {
            //IMenuMethod method = new MenuMethods();
            NewCommand = new RelayCommand(CreateNewChain);
            OpenCommand = new RelayCommand(OpenChain);
            SaveCommand = new RelayCommand(SaveChain);
            SaveAsCommand = new RelayCommand(SaveAsChain);
            RunCommand = new RelayCommand(RunChain);
            RunAllCommand = new RelayCommand(RunAllChain);
        }

        public ICommand OpenCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand SaveAsCommand { get; set; }
        public ICommand NewCommand { get; set; }
        public ICommand RunCommand { get; set; }
        public ICommand RunAllCommand { get; set; }
        public void CreateNewChain(object obj)
        {   

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
            
        }

        public void SaveChain(object obj)
        {
            TransformationViewModel TChain = new TransformationViewModel();
            var a = TChain.ChainList;
            var val = TChain.SelectedChain;

            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Creating object to xml"),
                new XElement("Transformation",
                //foreach(var map in val.Chain)

                new XElement("Map", new XAttribute("Sequence","0"),
                new XElement("MapFilePath", "1"),
                new XElement("TargetFilePath", "1"),
                new XElement("CodeModules", 
                //foreach(var path in val.
                new XElement("CodeModulePath","1"))

                )
                ));
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
