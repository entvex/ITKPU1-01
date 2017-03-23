using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using LogModule.Views;
using Prism.Events;
using Prism.Logging;
using Prism.Modularity;
using Prism.Regions;

namespace LogModule
{
    public class LogModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator _aggregator;

        public LogModule(IRegionManager regionManager, IEventAggregator aggregator)
        {
            _regionManager = regionManager;
            _aggregator = aggregator;
            _aggregator.GetEvent<MessageEvent>().Subscribe(logToConsole);
        }

        private void logToConsole(string message)
        {
            Console.WriteLine(message);
        }


        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionName.LogRegion, typeof (Views.LogView));
        }
    }
}
