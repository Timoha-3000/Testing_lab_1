using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Testing_lab_1.lab_1.Interfaces;

namespace Testing_lab_1.lab_1.classes
{
    public class CalculatorView : ICalculatorView
    {
        public double FirstArgument { get; set; }
        public double SecondArgument { get; set; }

        public CalculatorView() { }

        public void PrintResult(double result)
        {
            MessageBox.Show($"{result}", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void DisplayError(SystemException message)
        {
            MessageBox.Show($"{message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public string GetFirstArgumentAsString()
        {
            return FirstArgument.ToString();
        }

        public string GetSecondArgumentAsString()
        {
            return SecondArgument.ToString();
        }
    }
}
