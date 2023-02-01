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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operation = null;
        double temp = 0.0;
        bool zpt = false;
        double NumberMemory = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Buttons(object sender, RoutedEventArgs e)
        {
            string value = ((Button)sender).Content.ToString();
            tBox1.Text = (tBox1.Text != "0") ? tBox1.Text += value : value;
        }

        private void SetOperation(object sender, RoutedEventArgs e)
        {
            operation = ((Button)sender).Content.ToString();
            temp = Convert.ToDouble(tBox1.Text);
            tBox1.Text = "0";
            zpt = false;
        }

        private void btnR_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+" :
                    {
                        tBox1.Text = (temp + Convert.ToDouble(tBox1.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        tBox1.Text = (temp - Convert.ToDouble(tBox1.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        tBox1.Text = (temp * Convert.ToDouble(tBox1.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        tBox1.Text = (temp / Convert.ToDouble(tBox1.Text)).ToString();
                        break;
                    }
            }
            zpt = false;
        }

        private void btnPM_Click(object sender, RoutedEventArgs e)
        {
            tBox1.Text = (Convert.ToDouble(tBox1.Text)* (-1)).ToString();
        }

        private void btnZ_Click(object sender, RoutedEventArgs e)
        {
            if(!zpt)
                tBox1.Text += ",";
            zpt = true;

        }

        private void btnStr_Click(object sender, RoutedEventArgs e)
        {
            int len = tBox1.Text.Length;

            if (tBox1.Text.Length > 1)
            {
                if (len > 0)
                    tBox1.Text = tBox1.Text.Remove(len - 1);
            }
            else
                tBox1.Text = "0";
        }

        private void btn1X_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            operation = null;
            tBox1.Text = "0";
            double temp = 0;
           
        }

        private void btnMC_Click(object sender, RoutedEventArgs e)
        {
            NumberMemory = 0;
            tBox1.Text = "0";
        }

        private void btnP2_Click(object sender, RoutedEventArgs e)

        {
            double memory = NumberMemory + Convert.ToDouble(tBox1.Text);
            NumberMemory = memory;
            tBox1.Text = "0";
        }

        private void btnMM_Click(object sender, RoutedEventArgs e)
        {
            double memory = NumberMemory - Convert.ToDouble(tBox1.Text);
            NumberMemory = memory;
            tBox1.Text = "0";
        }

        private void btnMR_Click(object sender, RoutedEventArgs e)
        {
            
            tBox1.Text = Convert.ToString(NumberMemory);
        }

        private void btnMS_Click(object sender, RoutedEventArgs e)
        {
            NumberMemory = Convert.ToDouble(tBox1.Text);
            tBox1.Text = "0";
        }
    }
}
