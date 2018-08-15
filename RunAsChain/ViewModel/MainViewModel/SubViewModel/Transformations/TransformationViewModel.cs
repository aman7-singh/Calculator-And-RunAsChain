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
        private ObservableCollection<IRunAsChain> TempList = new ObservableCollection<IRunAsChain>();
        private ObservableCollection<IRunAsChain> _chainList = new ObservableCollection<IRunAsChain>();
        public ObservableCollection<IRunAsChain> ChainList
        {
            get { return _chainList; }
            set
            {
                _chainList = value;
            }
        }
        private ObservableCollection<IMap> _mapList = new ObservableCollection<IMap>();
        public ObservableCollection<IMap> MapList
        {
            get { return _mapList; }
            set
            {
                _mapList = value;
            }
        }
        private ObservableCollection<ICodeModule> _basPathList = new ObservableCollection<ICodeModule>();
        public ObservableCollection<ICodeModule> BasPathList
        {
            get { return _basPathList; }
            set
            {
                _basPathList = value;
            }
        }

        private ObservableCollection<FileInfo> _filePathList = new ObservableCollection<FileInfo>();
        public ObservableCollection<FileInfo> FilePathList
        {
            get { return _filePathList; }
            set
            {
                _filePathList = value;
            }
        }

        string path = @"C:\Users\1994a\source\repos\Calculator\RunAsChain\Model\RunAsChain1.xml";
        string path2 = @"C:\Users\1994a\source\repos\Calculator\RunAsChain\Model\RunAsChain.xml";

        private IRunAsChain _selectedChain;
        public IRunAsChain SelectedChain
        {
            get
            {
                if(_selectedChain ==null)
                {
                    _selectedChain = ChainList[0];
                }
                ObjectFilter(_selectedChain);
                return _selectedChain;
            }
            set
            {
                _selectedChain = value;
               
            }
        }
        private IMap _selectedMap;
        public IMap SelectedMap
        {
            get
            {
                if (_selectedMap == null)
                {
                    if(MapList.Count>0)
                    _selectedMap = MapList[0];
                    else
                        return _selectedMap;
                }
                ObjectFilter(_selectedMap);
                return _selectedMap;
            }
            set
            {
                _selectedMap = value;

            }
        }
        public void ObjectFilter(IMap SelectedMap)
        {
            BasPathList.Clear();
            foreach (var ch in SelectedMap.BasPaths.BasFilePathList)
            {
                BasPathList.Add(ch);
            }
            FilePathList.Clear();
            var srcpath = new FileInfo()
            {
                Path = SelectedMap.SrcPath,
                Type = "Source",
            };
            var tgtpath = new FileInfo()
            {
                Path = SelectedMap.TrgtPath,
                Type = "Target",
            };
            var Mappath = new FileInfo()
            {
                Path = SelectedMap.MapPath,
                Type = "Map",
            };
            FilePathList.Add(srcpath);
            FilePathList.Add(tgtpath);
            FilePathList.Add(Mappath);
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
        }

        public void ObjectFilter(IRunAsChain SelChain)
        {
            MapList.Clear();
            foreach (var ch in SelChain.Chain)
            {
                MapList.Add(ch);
            }
            ObjectFilter(MapList[0]);
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
