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

namespace RunAsChain.ViewModel.MainViewModel
{
    public class MainViewModel:Notify
    {
        //string path = @"C:\Users\1994a\source\repos\Calculator\RunAsChain\Model\RunAsChain1.xml";
        //private ObservableCollection<IMap> _MapList = new ObservableCollection<IMap>();
        //public ObservableCollection<IMap> MapList
        //{
        //    get { return _MapList; }
        //    set
        //    {
        //        _MapList = value;
        //        RaisePropertyChanged(this, "MapList");
        //    }
        //}
        public MainViewModel()
        {
            //XmlToObjectBuilder x = new XmlToObjectBuilder();
            //MapList = x.ModelObj(path);
            
        }
        //public object MapViewModelInstance
        //{
        //    get
        //    {
        //        return MapInstance();
        //    }
        //}
        //public object BasViewModelInstance
        //{
        //    get
        //    {
        //        return BasInstance();
        //    }
        //}
        //public object FileInfoViewModelInstance
        //{
        //    get
        //    {
        //        return FileInstance();
        //    }
        //}
        //public object BasInstance()
        //{
        //    var BasList = new ObservableCollection<ICodeModule>();
        //    var TempList = new ObservableCollection<ICodeModule>();
        //    foreach (var item in MapList)
        //    {
        //       //BasList= item.BasPaths.BasFilePathList;
        //       foreach(var b in item.BasPaths.BasFilePathList)
        //        {
        //            TempList.Add(b);
        //        }
        //    }
        //    BasList = TempList;
        //    BasViewModel BasInstance = new BasViewModel(path, BasList);
        //    return BasInstance;
        //}
        //public object MapInstance()
        //{
        //    MapViewModel MapInstance = new MapViewModel(path, MapList);
        //    return MapInstance;
        //}
        //public object FileInstance()
        //{
        //    List<FileInfo> FilepathList = new List<FileInfo>();
        //    foreach (var item in MapList)
        //    {
        //        var srcpath = new FileInfo()
        //        {
        //            Path = item.SrcPath,
        //            Type = "Source",
        //        };
        //        var tgtpath = new FileInfo()
        //        {
        //            Path = item.TrgtPath,
        //            Type = "Target",
        //        };
        //        var Mappath = new FileInfo()
        //        {
        //            Path = item.MapPath,
        //            Type = "Map",
        //        };
        //        FilepathList.Add(srcpath);
        //        FilepathList.Add(tgtpath);
        //        FilepathList.Add(Mappath);
        //    }
        //    FileInfoViewModel FileInstace = new FileInfoViewModel(FilepathList);
        //    return FileInstace;
        //}
    }
}
