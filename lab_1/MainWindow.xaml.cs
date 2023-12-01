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
using Testing_lab_1.lab_1.classes;

namespace lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculatorPresenter DataContex;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = new CalculatorPresenter();
        }

        public MainWindow(CalculatorPresenter viewModel)
        {
            InitializeComponent();

            DataContex = viewModel;
        }

        public void Multiplexer(object sender, RoutedEventArgs e)
        {
            if (DataContext is CalculatorPresenter dataContext)
            {
                if (sender is Button)
                {
                    Button button = (Button)sender;
                    if (button.Name == "Sum")
                        dataContext.OnPlusClicked();

                    if (button.Name == "Subtract")
                        dataContext.OnMinusClicked();

                    if (button.Name == "Multiply")
                        dataContext.OnMultiplyClicked();

                    if (button.Name == "Divide")
                        dataContext.OnDivideClicked();
                }
            }
        }

        public List<Button> AddAllElements()
        {
            List<Button> Controls = new List<Button>();

            Controls.Add(Sum);
            Controls.Add(Subtract);
            Controls.Add(Multiply);
            Controls.Add(Divide);

            return Controls;
        }
    }
}
