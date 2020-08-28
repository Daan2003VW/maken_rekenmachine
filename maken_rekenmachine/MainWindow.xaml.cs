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
//comit
namespace rekenmachine_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";

        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void btnKeer_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void btnGedeel_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void btnGelijk_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = 0;
                txtDisplay.Text = "0";
            }
            else
            {
                number2 = 0;
            }
            txtDisplay.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }

        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btnplusmin_Click(object sender, RoutedEventArgs e)
        {


            if (operation == "")
            {
                number1 *= -1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                txtDisplay.Text = number2.ToString();
            }
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

            if (Keyboard.IsKeyDown(Key.Back))
            {
                if (txtDisplay.Text != "")
                {
                    string Original = txtDisplay.Text;
                    string New = Original.Remove(Original.Length - 1);
                    txtDisplay.Text = New;
                }
            }
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            if (Keyboard.IsKeyDown(Key.NumPad0) || Keyboard.IsKeyDown(Key.D0))
            {
                txtDisplay.Text += "0";
            }
            if (Keyboard.IsKeyDown(Key.NumPad1) || Keyboard.IsKeyDown(Key.D1))
            {
                txtDisplay.Text += "1";
            }
            if (Keyboard.IsKeyDown(Key.NumPad1) || Keyboard.IsKeyDown(Key.D2))
            {
                txtDisplay.Text += "2";
            }
            if (Keyboard.IsKeyDown(Key.NumPad3) || Keyboard.IsKeyDown(Key.D3))
            {
                txtDisplay.Text += "3";
            }
            if (Keyboard.IsKeyDown(Key.NumPad4) || Keyboard.IsKeyDown(Key.D4))
            {
                txtDisplay.Text += "4";
            }
            if (Keyboard.IsKeyDown(Key.NumPad5) || Keyboard.IsKeyDown(Key.D5))
            {
                txtDisplay.Text += "5";
            }
            if (Keyboard.IsKeyDown(Key.NumPad6) || Keyboard.IsKeyDown(Key.D6))
            {
                txtDisplay.Text += "6";
            }
            if (Keyboard.IsKeyDown(Key.NumPad7) || Keyboard.IsKeyDown(Key.D7))
            {
                txtDisplay.Text += "7";
            }
            if (Keyboard.IsKeyDown(Key.NumPad8) || Keyboard.IsKeyDown(Key.D8))
            {
                txtDisplay.Text += "8";
            }
            if (Keyboard.IsKeyDown(Key.NumPad9) || Keyboard.IsKeyDown(Key.D9))
            {
                txtDisplay.Text += "9";
            }

        }

    }
}
