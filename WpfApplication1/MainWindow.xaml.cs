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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int counter = 0;

        Compute_number cn = new Compute_number();
        Compute_program cp = new Compute_program();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (n.IsChecked == true)
            {
                counter++;
                cn.Show();
                this.Hide();
            }
            else if (p.IsChecked == true)
            {
                counter++;
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select one item", "ERROR!!!", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void n_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

