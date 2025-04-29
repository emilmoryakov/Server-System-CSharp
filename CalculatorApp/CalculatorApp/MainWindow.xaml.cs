using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        private string input = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            input += button.Content.ToString();
            txtInput.Text = input;
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            if (!input.Contains("."))
            {
                input += ".";
                txtInput.Text = input;
            }
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (input.Length > 0)
            {
                input = input.Substring(0, input.Length - 1);
                txtInput.Text = input;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            input = "";
            txtInput.Text = input;
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            input += button.Content.ToString();
            txtInput.Text = input;
        }

        private void Calculate()
        {
            try
            {
                double result = Convert.ToDouble(new System.Data.DataTable().Compute(input, null));
                txtResult.Text = $"Result: {result}";
            }
            catch (Exception)
            {
                txtResult.Text = "Invalid expression!";
            }
        }
    }
}
