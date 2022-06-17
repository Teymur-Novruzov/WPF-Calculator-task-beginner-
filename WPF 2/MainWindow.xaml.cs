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

namespace WPF_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string math = "";
        public int check = 0;
        public int check_2 = 0;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void button_17_Click_1(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

            text_lbl.Content = "1";
            }
            else
            {

            text_lbl.Content += "1";
            }
        }

        private void button_18_Click_2(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

                text_lbl.Content = "2";
            }
            else
            {

                text_lbl.Content += "2";
            }
        }

        private void button_19_Click_3(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

                text_lbl.Content = "3";
            }
            else
            {

                text_lbl.Content += "3";
            }
        }

        private void button_22_Click_0(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

                
            }
            else
            {

                text_lbl.Content += "0";
            }
        }

        private void button_13_Click_4(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

                text_lbl.Content = "4";
            }
            else
            {

                text_lbl.Content += "4";
            }
        }

        private void button_14_Click_5(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

                text_lbl.Content = "5";
            }
            else
            {

                text_lbl.Content += "5";
            }
        }

        private void button_15_Click_6(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

                text_lbl.Content = "6";
            }
            else
            {

                text_lbl.Content += "6";
            }
        }

        private void button_9_Click_7(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

                text_lbl.Content = "7";
            }
            else
            {

                text_lbl.Content += "7";
            }
        }

        private void button_10_Click_8(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

                text_lbl.Content = "8";
            }
            else
            {

                text_lbl.Content += "8";
            }
        }

        private void button_11_Click_9(object sender, RoutedEventArgs e)
        {
            check = 0;
            if (text_lbl.Content.ToString() == "0")
            {

                text_lbl.Content = "9";
            }
            else
            {

                text_lbl.Content += "9";
            }
        }

        private void button_20_Click_plus(object sender, RoutedEventArgs e)
        {
            if (text_lbl.Content.ToString() != "" && text_lbl.Content.ToString() != "0" && check == 0)
            {
                text_lbl_2.Content = text_lbl.Content.ToString();
                text_lbl.Content = "";
                check = 1;
                math = "+";
                check_2 = 0;
            }
        }

        private void button_16_Click_minus(object sender, RoutedEventArgs e)
        {
            if (text_lbl.Content.ToString() != "" && text_lbl.Content.ToString() != "0" &&check==0)
            {
                text_lbl_2.Content = text_lbl.Content.ToString();
                text_lbl.Content = "";
                check = 1;
                math = "-";
                check_2 = 0;
            }
        }

        private void button_12_Click_mul(object sender, RoutedEventArgs e)
        {
           if(text_lbl.Content.ToString() != "" && check == 0)
            {

            text_lbl_2.Content = text_lbl.Content.ToString();
            text_lbl.Content = "";
                check = 1;
                math = "*";
                check_2 = 0;
            }
            
        }

        private void button_8_Click_div(object sender, RoutedEventArgs e)
        {
            if (text_lbl.Content.ToString() != "" && text_lbl.Content.ToString() != "0" && check == 0)
            {
                text_lbl_2.Content = text_lbl.Content.ToString();
                text_lbl.Content = "";
                check = 1;
                math = "/";
                check_2 = 0;
            }
        }

        private void button_24_Click_equal(object sender, RoutedEventArgs e)
        {
            double Sum1 = Convert.ToDouble(text_lbl.Content.ToString());
            double Sum2 = Convert.ToDouble(text_lbl_2.Content.ToString());
            double Sum3 =0;
            check = 0;
            if (math == "+")
            {
                Sum3 = Sum2 + Sum1;
                text_lbl.Content = Sum3.ToString();
                text_lbl_2.Content = "";
            }
            else if (math == "-")
            {
                Sum3 = Sum2 - Sum1;
                text_lbl.Content = Sum3.ToString();
                text_lbl_2.Content = "";
            }
            else if (math == "*")
            {
                Sum3 = Sum2 * Sum1;
                text_lbl.Content = Sum3.ToString();
                text_lbl_2.Content = "";
            }
            else if (math == "/")
            {
                Sum3 = Sum2 / Sum1;
                text_lbl.Content = Sum3.ToString();
                text_lbl_2.Content = "";
            }
        }

        private void button_6_Click_C(object sender, RoutedEventArgs e)
        {
            text_lbl.Content = "0";
            text_lbl_2.Content = "";
            check_2 = 0;
        }

        private void button_7_Click_del(object sender, RoutedEventArgs e)
        {
            double number = Convert.ToDouble(text_lbl.Content.ToString());
            double test_1;
            double test_2;
            int count=0;
            bool while_check = true;
            while (while_check)
            {
                if (Convert.ToInt32(number) != number)
                {
                    number *= 10;
                    count += 1;
                }
                else
                {
                    number = Convert.ToInt32(number) / 10;
                    for (int i = 0; i < count; i++)
                    {
                        number /= 10;
                    }

                    text_lbl.Content = number;
                    while_check = false;
                }

            }

        }

        private void button_23_Click__(object sender, RoutedEventArgs e)
        {
            if (check_2 == 0)
            {

            text_lbl.Content += ".";
                check_2 = 1;
            }
        }

        private void button_21_Click_MorP(object sender, RoutedEventArgs e)
        {
            double text_lbl_double = Convert.ToDouble(text_lbl.Content);
            text_lbl_double *= -1;
            text_lbl.Content = text_lbl_double.ToString();
        }

       
    }
}
