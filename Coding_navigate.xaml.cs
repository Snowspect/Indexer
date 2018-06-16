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
    /// Interaction logic for Coding_navigate.xaml
    /// </summary>
    public partial class Coding_navigate : Window
    {
        public Coding_navigate()
        {
            InitializeComponent();
        }

        private void Java_Click(object sender, RoutedEventArgs e)
        {
            Java_navigate sw = new Java_navigate();
            sw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            sw.Show();
        }
    }
}
