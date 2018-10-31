using Run_As_Chain.Command;
using Run_As_Chain.Model.ModelInterface;
using Run_As_Chain.ViewModel.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Run_As_Chain.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.OpenCommand = new RelayCommand(OpenAction);
        }

        public ICommand OpenCommand { get; set; }

        public void OpenAction(object obj)
        {
            string xmlPath = @"D:\VisualStudio\Calculator-And-RunAsChain\Run_As_Chain\Resource\RunAsChain1.xml";

            ChainTransformation chain = new ChainTransformation();
            chain.loadChain(xmlPath);
            _newChain = chain.ChainObj;
        }


        private ITransformationModel _newChain;

        public ITransformationModel NewChain
        {
            get { return _newChain; }
            set { _newChain = value; }
        }

        private ObservableCollection<IMapModel> _maps;

        public ObservableCollection<IMapModel> Maps
        {
            get { return NewChain.ProcessingStepsModel.Maps; }
            set { _maps = value; }
        }

    }
}
