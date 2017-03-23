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
using System.IO;

namespace LeakyApp
{
    /// <summary>
    /// Interaction logic for FileWindow.xaml
    /// </summary>
    public partial class FileWindow : Window
    {
        private MainWindow mainWindow;

        public FileWindow()
        {
            InitializeComponent();
        }

        public FileWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            mainWindow.OpacityChanged += new MainWindow.OpacityChangedEventHandler(mainWindow_OpacityChanged);
        }

        void mainWindow_OpacityChanged(object sender, OpacityChangedEventArgs e)
        {
            // 
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var fs = new FileStream("FilSomIkke Findes.borte", FileMode.Open, FileAccess.Read))
                {
                    using (var sr = new StreamReader(fs, Encoding.Default))
                    {
                        string str;

                        while (!sr.EndOfStream)
                        {
                            str = sr.ReadLine();
                        }
                        sr.Close();
                    }
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
