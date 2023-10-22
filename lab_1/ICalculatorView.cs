using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_lab_1.lab_1
{
    internal interface ICalculatorView
    {
        /**
        * Отображает результат вычисления
        */
        void PrintResult(double result);

        /**
         * Показывает ошибку, например деление на 0, пустые аргументы и прочее
         */
        void DisplayError(String message);

        /**
         * Возвращает значение, введенное в поле первого аргументы
         */
        String GetFirstArgumentAsString();

        /**
         * Возвращает значение, введенное в поле второго аргументы
         */
        String GetSecondArgumentAsString();

    }
}
