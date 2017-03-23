using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Prism.Modularity;
using Prism.Regions;

namespace StatusModule
{
    public class StatusModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public StatusModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionName.StatusRegion, typeof(Views.StatusView));
        }
    }
}
