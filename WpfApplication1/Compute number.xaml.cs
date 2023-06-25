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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Compute_number.xaml
    /// </summary>
    public partial class Compute_number : Window
    {
        
        string[] lines = new string[8];
        int counter = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        string s = "";
        double help = 0;
        double[] prime = new double[13] {2,3,5,7,11,13,17,19,23,27,29,31,37};
        double[] godel_numbers = new double[8];
        double thenumber = 0;
        double number=1;
        public double Pairing_function(double x,double y)
        {
            double result = 0;
            result = (Math.Pow(2, x) * (2 * y + 1)) - 1;
            return result;
        }
        public double godel_number()
        {
            

            for (int i = 0; i < 8; i++)
                number *= Math.Pow(prime[i],godel_numbers[i]);

            return number;
        }
        public Compute_number()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            this.Close();
            obj.Show();
            
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < counter ; i++)
            {
                string compare = "";
                s = lines[i];
                //               for(int j=s.Length-1;j>=0;j--)
                //              {
                a = 0;c = 0;

                    if (s[1] == 'A')
                        a = 1;
                    else if (s[1] == 'B')
                        a = 2;
                    else if (s[1] == 'C')
                        a = 3;
                    else if (s[1] == 'D')
                        a = 4;
                    else if (s[1] == 'E')
                        a = 5;

                    if (s[7] == 'X')
                        c = 1;
                    else if (s[7] == 'Z')
                        c = 2;
                    else if (s[7] == 'Y')
                        c = 0;

//                }
                compare = s.Substring(4);
                if (compare == "X<-X" || compare == "Y<-Y" || compare == "Z<-Z")
                    b = 0;
                else if (compare == "X<-X+1" || compare == "Y<-Y+1" || compare == "Z<-Z+1")
                    b = 1;
                else if (compare == "X<-X-1" || compare == "Y<-Y-1" || compare == "Z<-Z-1")
                    b = 2;
                else if (compare == "if X!=0 go to A"|| compare == "if Y!=0 go to A"|| compare == "if Z!=0 go to A")
                    b = 3;
                else if (compare == "if X!=0 go to B" || compare == "if Y!=0 go to B" || compare == "if Z!=0 go to B")
                    b = 4;
                else if (compare == "if X!=0 go to C" || compare == "if Y!=0 go to C" || compare == "if Z!=0 go to C")
                    b = 5;
                else if (compare == "if X!=0 go to D" || compare == "if Y!=0 go to D" || compare == "if Z!=0 go to D")
                    b = 6;
                else if (compare == "if X!=0 go to E" || compare == "if Y!=0 go to E" || compare == "if Z!=0 go to E")
                    b = 7;
               


                help = Pairing_function(b, c);
                godel_numbers[i] = Pairing_function(a, help);
                //
            }
            thenumber = godel_number() - 1;
            result.Content = "#(p)= " + thenumber;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if(textBox.Text!=null)
            {
                lines[counter] = textBox.Text;
                counter++;
                textBox.Clear();
            }
        }
    }
}
