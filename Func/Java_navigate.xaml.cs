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
using System.Windows.Shapes;

namespace Java_Uphit
{
    /// <summary>
    /// Interaction logic for Java_navigate.xaml
    /// </summary>
    public partial class Java_navigate : Window
    {
        public Java_navigate()
        {
            InitializeComponent();
        }

        // Opens the index window and closes this one (only want to keep the mainwindow hidden, the rest should be closed as the system goes on.
        private void Index_Click(object sender, RoutedEventArgs e)
        {
            Code_Index sw = new Code_Index();
            sw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            sw.Show();
            this.Close();
        }
    }
}
