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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

   

    public partial class MainWindow : Window
         

    {
        string oper = "";
        string firstvalue = "";
        string secondvalue = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void btnperc_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            firstvalue = "";
            secondvalue.Clone();
            txtresult.Clear();
            oper = "";


        }

        private void btnx_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnxhalf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnxsqu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnroutex_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btndivi_Click(object sender, RoutedEventArgs e)
        {
            oper = "/";
            txtresult.Clear();

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btn7.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btn7.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btn8.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btn8.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btn9.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btn9.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btnmulti_Click(object sender, RoutedEventArgs e)
        {
            oper = "*";
            txtresult.Clear();

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btn4.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btn4.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btn6.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btn6.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btn5.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btn5.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            oper = "-";
            txtresult.Clear();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
           if (oper == "")
            {
                firstvalue = firstvalue+ Convert.ToString(btn1.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue+ Convert.ToString(btn1.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btn2.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btn2.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btn3.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btn3.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            oper = "+";
            txtresult.Clear();
        }

        private void btnvalue_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btn0.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btn0.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btndot_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btndot.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btndot.Content);
                txtresult.Text = secondvalue;
            }
        }

        private void btnequal_Click(object sender, RoutedEventArgs e)
        {
            if (oper == "+")
            {
                int first = Convert.ToInt16(firstvalue);
                int second = Convert.ToInt32(secondvalue);  
                int result = first + second;
                txtresult.Text = Convert.ToString(result);  
            }
            else if (oper == "-")
            {
                int first = Convert.ToInt32(firstvalue);
                int second = Convert.ToInt32(secondvalue);
                int result = first - second;
                txtresult.Text = Convert.ToString(result);
            }
            else if (oper == "*") 
            {
                int first = Convert.ToInt32(firstvalue);
                int second = Convert.ToInt32(secondvalue);
                int result = first * second;
                txtresult.Text = Convert.ToString(result);
            }
            else if (oper == "/")
            {
                int first = Convert.ToInt32(firstvalue);
                int second = Convert.ToInt32(secondvalue);
                int result = first / second;
                txtresult.Text = Convert.ToString(result);
            }
        }
    }
}
