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
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double ?firstNum = null;
        double ?secondNum = null;
        char symb = '\0';
        public MainWindow()
        {
            InitializeComponent();
            Input.Text = "";
            Output.Text = "";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                Input.Text = "";
            }
            else
            {
                Output.Text = "";
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string text = "";
            for (int i = 0; i < Input.Text.Length - 1; i++)
            {
                text += Input.Text[i];
            }
            Input.Text = text;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (Input.Text != "")
            {
                firstNum = Convert.ToDouble(Input.Text) / 100;
                Output.Text = firstNum.ToString();
                Input.Text = "";
                symb = ' ';
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (Input.Text.Length <= 0)
                return;
            if (!Input.Text.Contains(','))
                Input.Text = Input.Text + ",";

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            if (firstNum != null)
            {
                secondNum = Convert.ToDouble(Input.Text);
                if (symb == '÷')
                    firstNum = firstNum / secondNum;
                else if (symb == '×')
                    firstNum = firstNum * secondNum;
                else if (symb == '-')
                    firstNum = firstNum - secondNum;
                else if (symb == '+')
                    firstNum = firstNum + secondNum;
                Output.Text = firstNum.ToString();
                Input.Text = "";
                symb = ' ';
            }
        }

        private void Button_Calc(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (firstNum == null)
            {
                firstNum = Convert.ToDouble(Input.Text);
                Output.Text += Input.Text;
            }
            else if (Input.Text != "")
            {
                secondNum = Convert.ToDouble(Input.Text);
                if (symb == '÷')
                    firstNum = firstNum / secondNum;
                else if (symb == '×')
                    firstNum = firstNum * secondNum;
                else if (symb == '-')
                    firstNum = firstNum - secondNum;
                else if (symb == '+')
                    firstNum = firstNum + secondNum;
                Output.Text = firstNum.ToString();

            }
            symb = Convert.ToChar(button.Content.ToString());
            Input.Text = "";
            Output.Text += symb.ToString();
        }

        private void Button_Num(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Input.Text = Input.Text + button.Content.ToString();
        }
    }
}
