using lab_1;
using LinqToDB.DataProvider;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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

        [Fact]
        public void ButtonClick_PerformOperationCalled()
        {
            // Arrange
            var mockDataProvider = new Mock<CalculatorPresenter>();
            //var viewModel = new MyViewModel(mockDataProvider.Object);
            var mainWindow = new MainWindow();

            // Act
            mainWindow.Multiplexer(null, null);

            // Assert
            mockDataProvider.Verify(dp => dp.OnDivideClicked(), Times.Never);
            // Другие утверждения, если необходимо
        }
    }
}
