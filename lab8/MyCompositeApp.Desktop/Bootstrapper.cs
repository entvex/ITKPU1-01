using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LogModule;
using Microsoft.Practices.Unity;
using ModuleA;
using ModuleB;
using Prism.Logging;
using Prism.Modularity;
using Prism.Unity;

namespace MyCompositeApp.Desktop
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override ILoggerFacade CreateLogger()
        {
            return new LoggerImpl();
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window) this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog) this.ModuleCatalog;
            moduleCatalog.AddModule(typeof (MenuModule.MenuModule));
            moduleCatalog.AddModule(typeof (StatusModule.StatusModule));
            moduleCatalog.AddModule(typeof (LogModule.LogModule));
            moduleCatalog.AddModule(typeof (ModuleAModule));
            moduleCatalog.AddModule(typeof (ModuleBModule));

        }
    }
}
