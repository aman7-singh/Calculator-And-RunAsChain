﻿using RunAsChain.Model;
using RunAsChain.Model.Interface;
using RunAsChain.ViewModel.Command;
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
            get
            {// Mediator.GetInstance().ChainChanged+= (s,e) => ObjectFilter(SelectedChain);
                return _mapList; }
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
            get
             {
                //Mediator.GetInstance().MapChanged += (s, e) => ObjectFilter(SelectedMap);
                return _filePathList;
            }
            set
            {
                _filePathList = value;
            }
        }

        string path = System.Environment.CurrentDirectory + @"\Model\RunAsChain1.xml";
        string path2 = System.Environment.CurrentDirectory + @"\Model\RunAsChain.xml";
        private IRunAsChain _selectedChain;
        public IRunAsChain SelectedChain
        {
            get
            {
                if (_selectedChain == null)
                {
                    _selectedChain = ChainList[0];
                }
                ObjectFilter(_selectedChain);
                return _selectedChain;
            }
            set
            {
                _selectedChain = value;
                //Mediator.GetInstance().OnChainChanged(this, value);
            }
        }
        private IMap _selectedMap;
        public IMap SelectedMap
        {
            get
            {
                if (_selectedMap == null)
                {
                        return _selectedMap;
                }
                ObjectFilter(_selectedMap);
                return _selectedMap;
            }
            set
            {
                _selectedMap = value;
                //if(value!=null)
                //Mediator.GetInstance().OnMapChanged(this, (IMap)value);
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
                ChainList.Add(ChainObj);
               // ChainList = TempList;
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
    }
}
