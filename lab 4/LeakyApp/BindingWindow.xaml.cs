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
    /// Interaction logic for BindingWindow.xaml
    /// </summary>
    public partial class BindingWindow : Window
    {
        int[] emptySpace = new int[27 * 1024 * 1024];

        public BindingWindow()
        {
            InitializeComponent();
        }

        public BindingWindow(Model model)
        {
            InitializeComponent();
            this.DataContext = model;
        }
    }
}
