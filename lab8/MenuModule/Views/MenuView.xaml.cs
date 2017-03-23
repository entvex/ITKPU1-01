using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prism.Regions;

namespace MenuModule.Views
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        private readonly IRegionManager _regionManager;

        public MenuView(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            InitializeComponent();
        }

        private void ModuleABtn_OnClick(object sender, RoutedEventArgs e)
        {
            _regionManager.RequestNavigate("MainRegion", new Uri("ViewA", UriKind.Relative));
        }

        private void ModuleBBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _regionManager.RequestNavigate("MainRegion", new Uri("ViewB", UriKind.Relative));
        }
    }
}
