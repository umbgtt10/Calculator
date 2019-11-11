using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Calculator
{
    public enum Operator
    {
        Plus = 0,
        Minus = 1,
        Mol = 2,
        Div = 3,
        Equals = 10,
    }

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ICalculator calculator;

        public MainPage(ICalculator calculator)
        {
            this.calculator = calculator;

            InitializeComponent();
        }

        private void OnButton_1_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("1"));

            UpdateResult("1");
        }

        private void OnButton_2_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("2"));

            UpdateResult("2");
        }

        private void OnButton_3_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("3"));

            UpdateResult("3");
        }

        private void OnButton_4_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("4"));

            UpdateResult("4");
        }

        private void OnButton_5_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("5"));

            UpdateResult("5");
        }

        private void OnButton_6_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("6"));

            UpdateResult("6");
        }

        private void OnButton_7_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("7"));

            UpdateResult("7");
        }

        private void OnButton_8_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("8"));

            UpdateResult("8");
        }

        private void OnButton_9_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("9"));

            UpdateResult("9");
        }

        private void OnButton_0_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperand(double.Parse("0"));

            UpdateResult("0");
        }

        private void OnButton_Plus_Clicked(object sender, EventArgs e)
        {
            calculator.AddOperator(Operator.Plus);

            UpdateResult("+");
        }

        private void OnButton_Minus_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("-");
        }

        private void OnButton_Div_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("/");
        }

        private void OnButton_X_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("*");
        }

        private void OnButton_Equals_Clicked(object sender, EventArgs e)
        {
            var result = calculator.GetResult().ToString();

            SetResult(result);
        }

        private void OnButton_PlusMinus_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("+/-");
        }

        private void OnButton_C_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("C");
        }

        private void OnButton_Percent_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException("%");
        }

        private void OnButton_Period_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException(".");
        }

        private void UpdateResult(string value)
        {
            Result.Text += value;
        }

        private void SetResult(string value)
        {
            Result.Text = value;
        }
    }
}
