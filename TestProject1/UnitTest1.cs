using Testing_lab_1.lab_1.classes;

namespace TestProject1
{
    public class UnitTest1
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
        public void CalculatorSubtractTest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double a = 100, b = 200, result = 0;

            // Act
            result = calculator.Subtract(a, b);

            // Assert
            Assert.Equal(-100, result);
        }

        [Fact]
        public void CalculatorDIvideTest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double a = 100, b = 200, result = 0;

            // Act
            result = calculator.Divide(a, b);

            // Assert
            Assert.Equal(0.5, result);
        }

        [Fact]
        public void CalculatorMultiplyTest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double a = 100, b = 200, result = 0;

            // Act
            result = calculator.Multiply(a, b);

            // Assert
            Assert.Equal(20000, result);
        }

        [Fact]
        public void CalculatorMultiplyOnZeroTest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double a = 100, b = 0, result = 0;

            // Act
            result = calculator.Divide(a, b);

            // Assert
            Assert.Equal(double.NaN, result);
        }


        [Fact]
        public void CalculatorMultiplyByMinimumTest()
        {
            // Arrange
            Calculator calculator = new Calculator();
            double a = 100, b = 10e-9, result = 0;

            // Act
            result = calculator.Divide(a, b);

            // Assert
            Assert.Equal(double.NaN, result);
        }
    }
}