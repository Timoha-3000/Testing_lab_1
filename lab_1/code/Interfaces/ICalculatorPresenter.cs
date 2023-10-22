using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_lab_1.lab_1.Interfaces
{
    public interface ICalculatorPresenter
    {
        /**
         * Вызывается формой в тот момент, когда пользователь нажал на кнопку '+'
         */
        void OnPlusClicked();

        /**
         * Вызывается формой в тот момент, когда пользователь нажал на кнопку '-'
         */
        void OnMinusClicked();

        /**
         * Вызывается формой в тот момент, когда пользователь нажал на кнопку '/'
         */
        void OnDivideClicked();

        /**
         * Вызывается формой в тот момент, когда пользователь нажал на кнопку '*'
         */
        void OnMultiplyClicked();

    }
}
