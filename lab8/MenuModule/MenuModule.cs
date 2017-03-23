using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Prism.Logging;
using Prism.Modularity;
using Prism.Regions;

namespace MenuModule
{
    public class MenuModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MenuModule(IRegionManager manager)
        {
            this._regionManager = manager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionName.MenuRegion, typeof(Views.MenuView));
        }
    }
}
