using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using ModuleA.View;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        IRegionManager _regionManager;
        private readonly IEventAggregator _aggregator;

        public ModuleAModule(IRegionManager regionManager,IEventAggregator aggregator)
        {
            _regionManager = regionManager;
            _aggregator = aggregator;

            _aggregator.GetEvent<MessageEvent>().Publish("ModuleAModule");
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(ViewA));
            _aggregator.GetEvent<MessageEvent>().Publish("ModuleAModule");
        }
    }
}
