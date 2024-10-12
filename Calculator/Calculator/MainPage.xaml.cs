using System;
using Microsoft.Maui.Controls;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        double currentValue = 0;       
        double previousValue = 0;      
        string operatorClicked = "";   
        bool isNewInput = true;        

        public MainPage()
        {
            InitializeComponent();
        }

        void OnNumberClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;

            if (ResultLabel.Text == "0" || isNewInput)
            {
                ResultLabel.Text = number;
                isNewInput = false;
            }
            else
            {
                ResultLabel.Text += number;
            }

            currentValue = Convert.ToDouble(ResultLabel.Text);
        }

        void OnClearClicked(object sender, EventArgs e)
        {
            currentValue = 0;
            previousValue = 0;
            operatorClicked = "";
            ResultLabel.Text = "0";
            isNewInput = true;
        }

        void OnDecimalClicked(object sender, EventArgs e)
        {
            if (!ResultLabel.Text.Contains("."))
            {
                ResultLabel.Text += ".";
                isNewInput = false;
            }
        }
        void OnSqrtClicked(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(ResultLabel.Text);
            double result = Math.Sqrt(number);
            ResultLabel.Text = result.ToString();
        }

        void OnSquareClicked(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(ResultLabel.Text);
            double result = Math.Pow(number, 2);
            ResultLabel.Text = result.ToString();
        }

        void OnOperatorClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorClicked = button.Text;
            previousValue = currentValue;
            isNewInput = true;
        }

        void OnEqualClicked(object sender, EventArgs e)
        {
            double result = 0;

            switch (operatorClicked)
            {
                case "+":
                    result = previousValue + currentValue;
                    break;
                case "-":
                    result = previousValue - currentValue;
                    break;
                case "×":
                    result = previousValue * currentValue;
                    break;
                case "÷":
                    if (currentValue != 0)
                    {
                        result = previousValue / currentValue;
                    }
                    else
                    {
                        ResultLabel.Text = "Hata";  
                        isNewInput = true;
                        return;
                    }
                    break;
            }

            ResultLabel.Text = result.ToString();
            currentValue = result;
            isNewInput = true;
        }
    }
}
