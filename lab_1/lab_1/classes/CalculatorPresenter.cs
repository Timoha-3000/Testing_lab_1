using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Testing_lab_1.lab_1.Interfaces;

namespace Testing_lab_1.lab_1.classes
{
    public class CalculatorPresenter : ICalculatorPresenter, INotifyPropertyChanged
    {
        public double FirstArgument { get; set; }
        public double SecondArgument { get; set; }
        public double Result { get; set; }
        private Calculator Calculator { get; set; }
        private CalculatorView CalculatorView { get; set; }

        public CalculatorPresenter()
        {
            Calculator = new Calculator();
            CalculatorView = new CalculatorView();
        }

        /// <summary>
        /// Вызывается формой в тот момент, когда пользователь нажал на кнопку '+'
        /// </summary>
        public void OnPlusClicked()
        {
            Result = Calculator.Sum(FirstArgument, SecondArgument);
            CalculatorView.PrintResult(Result);
        }

        /// <summary>
        /// Вызывается формой в тот момент, когда пользователь нажал на кнопку '-'
        /// </summary>
        public void OnMinusClicked()
        {
            Result = Calculator.Subtract(FirstArgument, SecondArgument);
            CalculatorView.PrintResult(Result);
        }

        /// <summary>
        /// Вызывается формой в тот момент, когда пользователь нажал на кнопку '/'
        /// </summary>
        public void OnDivideClicked()
        {
            Result = Calculator.Divide(FirstArgument, SecondArgument);
            CalculatorView.PrintResult(Result);
        }

        /// <summary>
        /// Вызывается формой в тот момент, когда пользователь нажал на кнопку '*'
        /// </summary>
        public void OnMultiplyClicked()
        {
            Result = Calculator.Multiply(FirstArgument, SecondArgument);
            CalculatorView.PrintResult(Result);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
