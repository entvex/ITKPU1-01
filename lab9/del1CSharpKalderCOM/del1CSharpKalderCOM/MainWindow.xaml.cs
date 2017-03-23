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
using exercise3_1Lib;

namespace del1CSharpKalderCOM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private Icalc calculator = new calc() as Icalc;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            string SelectedOpration = comboBox.Text;
            if (SelectedOpration == "Add")
            {
                int res;
                calculator.Add(int.Parse(textBoxArg1.Text), int.Parse(textBoxArg2.Text),out res);
                textBoxRes.Text = res.ToString();
            }

            if (SelectedOpration == "Sub")
            {

                int res = calculator.Sub(int.Parse(textBoxArg1.Text), int.Parse(textBoxArg2.Text));
                textBoxRes.Text = res.ToString();
            }
        }

        private void TextBox_Copy_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                calculator.offset = int.Parse(textBoxOffset.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
