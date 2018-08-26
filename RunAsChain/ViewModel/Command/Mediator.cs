using RunAsChain.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunAsChain.ViewModel.Command
{
    public sealed class Mediator
    {
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { }
        public static Mediator GetInstance()
        { return _Instance; }

        public event EventHandler<MapChangedEventArgs> MapChanged;
        public void OnMapChanged(object sender, IMap map)
        {
            if (MapChanged != null)
                MapChanged(sender, new MapChangedEventArgs { Map = map });
        }
        public event EventHandler<ChainChangedEventArgs> ChainChanged;
        public void OnChainChanged(object sender, IRunAsChain chain)
        {
            if (ChainChanged!=null)
            {
                ChainChanged(sender, new ChainChangedEventArgs { Chain = chain });
            }
        }
    }
}
