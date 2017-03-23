using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LeakyApp
{
    /// <summary>
    /// Interaction logic for NameWindow.xaml
    /// </summary>
    public partial class NameWindow : Window
    {
        float[] emptySpace = new float[17 * 1024 * 1024];
        MainWindow mainWnd = null;

        public NameWindow()
        {
            InitializeComponent();
        }

        public NameWindow(MainWindow main)
        {
            InitializeComponent();
            mainWnd = main;
        }

        public void mainWin_NameChanged(object sender, TextChangedEventArgs e)
        {
            tbxName.Text = mainWnd.tbxName.Text;
        }
        protected override void OnClosed(EventArgs e)
        {
            mainWnd.tbxName.TextChanged -= mainWin_NameChanged;
            base.OnClosed(e);

        }
    }
}
