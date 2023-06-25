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
    /// Interaction logic for Compute_program.xaml
    /// </summary>
    public partial class Compute_program : Window
    {
        int[] alpha = { 0, 0, 0, 0, 0, 0, 0, 0 };
        int number = 0;
        int a, b, c;
        int[] list = new int[3];
        string[] show = new string[8];
        int counter = 0;
        int help;


        int[] revpairingf(int pn)
        {
            int eq = pn + 1;
            int x = 0;
            while(eq%2==0)
            {
                eq = eq / 2;
                x++;
            }
            int y = 0;
            if(eq%2==1)
            {
                eq--;
                y = eq / 2;
            }
            return new int[] { x, y };
        }
        int[] revers_function(int m)
        {
            int[] abc = revpairingf(m);
            int a2 = abc[0];
            int[] bc = revpairingf(abc[1]);
            int b2 = bc[0];
            int c2 = bc[1];

            list[0] = a2;
            list[1] = b2;
            list[2] = c2;

            return list;

        }
        void show_program(int[] ints)
        {
            
            bool control = true;
            double a1, b1, c1;
            a1 = ints[0];
            b1 = ints[1];
            c1 = ints[2];
            while(control)
            {
                if (a1 == 0)
                    show[counter] = "     ";
                else if (a1 == 1)
                    show[counter] = "[A]  ";
                else if (a1 == 2)
                    show[counter] = "[B]  ";
                else if (a1 == 3)
                    show[counter] = "[C]  ";
                else if (a1 == 4)
                    show[counter] = "[D]  ";
                else if (a1 == 5)
                    show[counter] = "[E]  ";
                if (c1 == 0)
                {
                    if (b1 == 0)
                        show[counter] = show[counter] + "Y<-Y";
                    else if (b1 == 1)
                        show[counter] = show[counter] + "Y<-Y+1";
                    else if (b1 == 2)
                        show[counter] = show[counter] + "Y<-Y-1";
                    else if (b1 == 3)
                        show[counter] = show[counter] + "if Y!=0 go to A";
                    else if (b1 == 4)
                        show[counter] = show[counter] + "if Y!=0 go to B";
                    else if (b1 == 5)
                        show[counter] = show[counter] + "if Y!=0 go to C";
                    else if (b1 == 6)
                        show[counter] = show[counter] + "if Y!=0 go to D";
                    else if (b1 == 7)
                        show[counter] = show[counter] + "if Y!=0 go to E";
                }
                else if (c1==1)
                {
                    if (b1 == 0)
                        show[counter] = show[counter] + "X<-X";
                    else if (b1 == 1)
                        show[counter] = show[counter] + "X<-X+1";
                    else if (b1 == 2)
                        show[counter] = show[counter] + "X<-X-1";
                    else if (b1 == 3)
                        show[counter] = show[counter] + "if X!=0 go to A";
                    else if (b1 == 4)
                        show[counter] = show[counter] + "if X!=0 go to B";
                    else if (b1 == 5)
                        show[counter] = show[counter] + "if X!=0 go to C";
                    else if (b1 == 6)
                        show[counter] = show[counter] + "if X!=0 go to D";
                    else if (b1 == 7)
                        show[counter] = show[counter] + "if X!=0 go to E";
                }
                else if (c1 == 2)
                {
                    if (b1 == 0)
                        show[counter] = show[counter] + "Z<-Z";
                    else if (b1 == 1)
                        show[counter] = show[counter] + "Z<-Z+1";
                    else if (b1 == 2)
                        show[counter] = show[counter] + "Z<-Z-1";
                    else if (b1 == 3)
                        show[counter] = show[counter] + "if Z!=0 go to A";
                    else if (b1 == 4)
                        show[counter] = show[counter] + "if Z!=0 go to B";
                    else if (b1 == 5)
                        show[counter] = show[counter] + "if Z!=0 go to C";
                    else if (b1 == 6)
                        show[counter] = show[counter] + "if Z!=0 go to D";
                    else if (b1 == 7)
                        show[counter] = show[counter] + "if Z!=0 go to E";
                }

                control = false;
                
            }

            counter++;
        }

        void reverse_godel(int p)
        {
            int j = Convert.ToInt32(p);
            for (int i =0;j!=1;i++)
            {
                if(j%2==0)
                {
                    help = 1;
                    j = j / 2;
                    alpha[0]++;
                }
                else if (j % 3 == 0)
                {
                    help = 2;
                    j = j / 3;
                    alpha[1]++;
                }
                else if (j % 5 == 0)
                {
                    help = 3;
                    j = j / 5;
                    alpha[2]++;
                }
                else if (j % 7 == 0)
                {
                    help = 4;
                    j = j / 7;
                    alpha[3]++;
                }
                else if (j % 11 == 0)
                {
                    help = 5;
                    j = j / 11;
                    alpha[4]++;
                }
                else if (j % 13 == 0)
                {
                    help = 6;
                    j = j / 13;
                    alpha[5]++;
                }
                else if (j % 17 == 0)
                {
                    help = 7;
                    j = j / 17;
                    alpha[6]++;
                }
                else if (j % 19 == 0)
                {
                    help = 8;
                    j = j / 19;
                    alpha[7]++;
                }
            } 
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            this.Close();
            obj.Show();
        }

        public Compute_program()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            number = Convert.ToInt32(textBox.Text) + 1;
            reverse_godel(number);
            for (int j = 0; j < help; j++)
                show_program(revers_function(alpha[j]));
            for (int i = 0; i < show.Length; i++)
                result.Content +=  show[i] + "\n";
        }
    }
}
