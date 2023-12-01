using lab_1;
using Moq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Testing_lab_1.lab_1.classes;

namespace TestProject1
{
    public class Lab2UITests
    {
        [Fact]
        public void CalculatorSumTest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double a = 100, b = 200, result = 0;

            // Act
            result = calculator.Sum(a, b);

            // Assert
            Assert.Equal(300, result);
        }

        /*[WpfFact]
        public void ButtonClickDivideTest()
        {
            Thread thread = new Thread(() =>
            {
                // Arrange
                var mockDataProvider = new Mock<CalculatorPresenter>();
                var viewModel = new CalculatorPresenter(mockDataProvider.Object);
                var mainWindow = new MainWindow();

                // Act
                mainWindow.Multiplexer(null, null);

                // Assert
                mockDataProvider.Verify(dp => dp.OnDivideClicked(), Times.Never);
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }*/

        [UIFact]
        public void ButtonClickMultiply()
        {
            // Arrange
            
            var dataProvider = new CalculatorPresenter();
            dataProvider.FirstArgument = 1;
            dataProvider.SecondArgument = 2;
            var mainWindow = new MainWindow(dataProvider);

            // Act
            mainWindow.Multiplexer(new Button() { Name = "Multiply" }, new System.Windows.RoutedEventArgs() { });

            // Assert
            Assert.Equal(2, dataProvider.Result);        
        }

        [UIFact]
        public void ButtonClickSum()
        {
            // Arrange

            var dataProvider = new CalculatorPresenter();
            dataProvider.FirstArgument = 1;
            dataProvider.SecondArgument = 2;
            var mainWindow = new MainWindow(dataProvider);

            // Act
            mainWindow.Multiplexer(new Button() { Name = "Sum" }, new System.Windows.RoutedEventArgs() { });

            // Assert
            Assert.Equal(3, dataProvider.Result);
        }

        [UIFact]
        public void ButtonClickSubtract()
        {
            // Arrange

            var dataProvider = new CalculatorPresenter();
            dataProvider.FirstArgument = 1;
            dataProvider.SecondArgument = 2;
            var mainWindow = new MainWindow(dataProvider);

            // Act
            mainWindow.Multiplexer(new Button() { Name = "Subtract" }, new System.Windows.RoutedEventArgs() { });

            // Assert
            Assert.Equal(-1, dataProvider.Result);
        }

        [UIFact]
        public void ButtonClickDivide()
        {
            // Arrange

            var dataProvider = new CalculatorPresenter();
            dataProvider.FirstArgument = 44;
            dataProvider.SecondArgument = 2;
            var mainWindow = new MainWindow(dataProvider);

            // Act
            mainWindow.Multiplexer(new Button() { Name = "Divide" }, new System.Windows.RoutedEventArgs() { });

            // Assert
            Assert.Equal(22, dataProvider.Result);
        }

        [UIFact]
        public void ButtonClickDivideTest()
        {
            // Arrange
            var dataProvider = new CalculatorPresenter();

            // Act
            var mainWindow = new MainWindow(dataProvider);

            // Assert
            Assert.Equal(Visibility.Collapsed, mainWindow.Visibility);
        }

        [UIFact]
        public void ButtonClickSumTest()
        {
            // Arrange
            var dataProvider = new CalculatorPresenter();
            dataProvider.FirstArgument = 44;
            dataProvider.SecondArgument = 2;
            var mainWindow = new MainWindow(dataProvider);

            // Act
            List<Button> buttons = mainWindow.AddAllElements();
            var but = buttons.Where(e => e.Name == "Sum").FirstOrDefault();

            if(but != null) but.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));

            // Assert
            Assert.Equal(46, dataProvider.Result);
        }
    }
}
