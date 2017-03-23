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
using Common;
using Prism.Events;
using Prism.Logging;

namespace MyCompositeApp.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell : Window
    {
        private ILoggerFacade _logger;
        private IEventAggregator _aggregator;

        public Shell(ILoggerFacade logger, IEventAggregator aggregator)
        {
            _logger = logger;
            _aggregator = aggregator;
            _aggregator.GetEvent<MessageEvent>().Publish("Hej fra Shell");
            InitializeComponent();
        }
    }
}
