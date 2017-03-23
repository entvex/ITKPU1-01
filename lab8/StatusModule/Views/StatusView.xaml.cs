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

namespace StatusModule.Views
{
    /// <summary>
    /// Interaction logic for StatusView.xaml
    /// </summary>
    public partial class StatusView : UserControl
    {
        private readonly IEventAggregator _aggregator;

        public StatusView(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
            _aggregator.GetEvent<MessageEvent>().Subscribe(WriteMessage);
            InitializeComponent();
        }

        private void WriteMessage(string str)
        {
            StatusBlock.Text = str;
        }
    }
}
