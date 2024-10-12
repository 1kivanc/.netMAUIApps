using System;
using Microsoft.Maui.Controls;

namespace basicCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
        }
        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            double number1 = double.Parse(Number1Entry.Text); 
            double number2 = double.Parse(Number2Entry.Text); 
            double result = number1 + number2; 
            DisplayAlert("Sonuç", $"Sonuç: {result}", "OK"); 
        }

        private void OnSubtractButtonClicked(object sender, EventArgs e)
        {
            double number1 = double.Parse(Number1Entry.Text);
            double number2 = double.Parse(Number2Entry.Text); 
            double result = number1 - number2; 
            DisplayAlert("Sonuç", $"Sonuç: {result}", "OK"); 
        }

        private void OnMultiplyButtonClicked(object sender, EventArgs e)
        {
            double number1 = double.Parse(Number1Entry.Text); 
            double number2 = double.Parse(Number2Entry.Text); 
            double result = number1 * number2; 
            DisplayAlert("Sonuç", $"Sonuç: {result}", "OK"); 
        }

        private void OnDivideButtonClicked(object sender, EventArgs e)
        {
            double number1 = double.Parse(Number1Entry.Text); 
            double number2 = double.Parse(Number2Entry.Text); 
            double result = number1 / number2; 
            DisplayAlert("Sonuç", $"Sonuç: {result}", "OK"); 
        }
    }
}
