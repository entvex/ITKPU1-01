using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleB.View;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleB
{
    public class ModuleBModule : IModule
    {
        IRegionManager _regionManager;
        private readonly IEventAggregator _aggregator;

        public ModuleBModule(IRegionManager regionManager, IEventAggregator aggregator)
        {
            _regionManager = regionManager;
            _aggregator = aggregator;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(ViewB));
        }
    }
}
