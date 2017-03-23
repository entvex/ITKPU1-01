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
using ClassLibrary1Signed;

namespace WpfApplicationTestUsingSignedDLL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {          
            var CprDll = new CprDll();
            Type assType = CprDll.GetType();

            textBox1.Text = assType.Assembly.CodeBase;

            CprError cprError;
            if (CprDll.Check(textBox.Text, out cprError))
            {
                MessageBox.Show("Good guy");
            }
            else
            {
                MessageBox.Show("Skod man kvinde ting.");
            }
        }
    }
}
