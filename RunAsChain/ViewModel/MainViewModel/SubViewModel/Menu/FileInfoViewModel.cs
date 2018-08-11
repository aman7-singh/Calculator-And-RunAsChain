using RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.MainViewModel.SubViewModel.Menu
{
    public class FileInfoViewModel
    {
        private string _srcPath;

       
        private List<FileInfo> _fileInfo = new List<FileInfo>();

        public List<FileInfo> FileInfo
        {
            get { return _fileInfo; }
            set { _fileInfo = value; }
        }

        public FileInfoViewModel(List<FileInfo> paths)
        {
            FileInfo = paths;
        }

    }
}
