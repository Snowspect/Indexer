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

namespace Java_Uphit
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

        // Opens the window related to "coding"
        private void Coding_Click(object sender, RoutedEventArgs e)
        {
            Coding_navigate sw = new Coding_navigate();
            sw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            sw.Show();
            this.Hide();
        }

        //Opens the window related to Add code "bottom right of screen" /not in coding section
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddCode sw = new AddCode();
            sw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            sw.Show();
            this.Hide();
        }
    }
}