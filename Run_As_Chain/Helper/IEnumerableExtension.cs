using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_As_Chain.Helper
{
    public static class IEnumerableExtension
    {
        private static ObservableCollection<object> ObservableList = new ObservableCollection<object>();
        public static ObservableCollection<object> IEnumerableToObservableCollection<T>(this IEnumerable<T> Listtoconvert)
        {
            ObservableList.Clear();
            foreach (var obj in Listtoconvert)
            {
                ObservableList.Add(obj);
            }
            return ObservableList;
        }
    }
}
