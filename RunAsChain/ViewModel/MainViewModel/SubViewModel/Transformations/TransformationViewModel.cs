using RunAsChain.Model;
using RunAsChain.Model.Interface;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu;
using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.HelperClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Transformations
{
    public class TransformationViewModel : Notify
    {
        private List<IRunAsChain> TempList = new List<IRunAsChain>();
        private List<IRunAsChain> _chainList;
        public List<IRunAsChain> ChainList
        {
            get { return _chainList; }
            set
            {
                _chainList = value;
                RaisePropertyChanged(this, "ChainList");
            }
        }
        private ObservableCollection<IMap> _mapList;
        public ObservableCollection<IMap> MapList
        {
            get { return _mapList; }
            set
            {
                _mapList = value;
                RaisePropertyChanged(this, "MapList");
            }
        }
        string path = @"C:\Users\1994a\source\repos\Calculator\RunAsChain\Model\RunAsChain1.xml";
        string path2 = @"C:\Users\1994a\source\repos\Calculator\RunAsChain\Model\RunAsChain.xml";

        private IRunAsChain _selectedChain;
        public IRunAsChain SelectedChain
        {
            get
            {
                return _selectedChain;
            }
            set
            {
                _selectedChain = value;
                ObjectFilter(value.ChainPath);
            }
        }
        public TransformationViewModel()
        {
            int i = 0;
            List<string> PathList = new List<string>() { path, path2 };
            foreach (var path in PathList)
            {
                XmlToObjectBuilder x = new XmlToObjectBuilder();
                IRunAsChain ChainObj = new RunAsChain.Model.RunAsChain()
                {
                    ChainPath = PathList[i],
                    Chain = x.ModelObj(PathList[i])
                };
                TempList.Add(ChainObj);
                ChainList = TempList;
                i++;
            }
            ObjectFilter(ChainList[0].ChainPath);
        }

        public void ObjectFilter(string SelChain)
        {
            foreach (var ch in ChainList)
            {
                if (ch.ChainPath == SelChain)
                {
                    MapList = ch.Chain;
                }
            }
        }
        public object MapViewModelInstance
        {
            get
            {
                return MapInstance();
            }
        }
        public object BasViewModelInstance
        {
            get
            {
                return BasInstance();
            }
        }
        public object FileInfoViewModelInstance
        {
            get
            {
                return FileInstance();
            }
        }
        public object BasInstance()
        {
            var BasList = new ObservableCollection<ICodeModule>();
            var TempList = new ObservableCollection<ICodeModule>();
            foreach (var item in MapList)
            {
                foreach (var b in item.BasPaths.BasFilePathList)
                {
                    TempList.Add(b);
                }
            }
            BasList = TempList;
            BasViewModel BasInstance = new BasViewModel(path, BasList);
            return BasInstance;
        }
        public object MapInstance()
        {
            MapViewModel MapInstance = new MapViewModel(path, MapList);
            return MapInstance;
        }
        public object FileInstance()
        {
            List<FileInfo> FilepathList = new List<FileInfo>();
            foreach (var item in MapList)
            {
                var srcpath = new FileInfo()
                {
                    Path = item.SrcPath,
                    Type = "Source",
                };
                var tgtpath = new FileInfo()
                {
                    Path = item.TrgtPath,
                    Type = "Target",
                };
                var Mappath = new FileInfo()
                {
                    Path = item.MapPath,
                    Type = "Map",
                };
                FilepathList.Add(srcpath);
                FilepathList.Add(tgtpath);
                FilepathList.Add(Mappath);
            }
            FileInfoViewModel FileInstace = new FileInfoViewModel(FilepathList);
            return FileInstace;
        }
    }
}
