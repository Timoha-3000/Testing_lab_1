using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_lab_1.lab_1.Interfaces;

namespace Testing_lab_1.lab_1.classes
{
    public class Calculator : ICalculator, INotifyPropertyChanged
    {
        private CalculatorView view;
        public Calculator() { view = new CalculatorView(); }

        public double Sum (double a, double b)
        {

            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0 || b < 10e-8) { view.DisplayError(new ArithmeticException()); return double.NaN; };
            return a / b;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
