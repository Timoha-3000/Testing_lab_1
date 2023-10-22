using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_lab_1.lab_1.Interfaces;
using Xunit.Sdk;

namespace Testing_lab_1.lab_1.classes
{
    public class Calculator : ICalculator
    {
        public Calculator() { }

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
            return a / b;
        }
    }
}
