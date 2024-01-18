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

namespace CalculatorBMI
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateBMI_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(WeightTextBox.Text, out double weight) 
                && double.TryParse(HeightTextBox.Text, out double height))
            {
                height = height / 100;
                double bmi = weight / (height * height);
                string resultText = $"Twoje BMI wynosi: {bmi:F2} ";

                if (bmi < 16)
                {
                    resultText += "wygłodzenie";
                }
                else if (bmi < 17)
                {
                    resultText += "wychudzenie";
                }
                else if (bmi < 18.5)
                {
                    resultText += "niedowaga";
                }
                else if (bmi < 25)
                {
                    resultText += "waga prawidłowa";
                }
                else if (bmi < 30)
                {
                    resultText += "nadwaga";
                }
                else if (bmi < 35)
                {
                    resultText += "otyłość I stopnia";
                }
                else if (bmi < 40)
                {
                    resultText += "otyłość II stopnia";
                }
                else
                {
                    resultText += "otyłość III stopnia";
                }

                BMIResultTextBlock.Text = resultText;
            }
            else
            {
                BMIResultTextBlock.Text = "Wprowadź poprawne dane.";
            }
        }
    }
}