using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    public class Calculator
    {
        double a, b;
        public double sum(int a, int b)
        {
            return a + b;
        }
        public double substract(int a, int b)
        {
            return a - b;
        }
        public double multiply(int a, int b)
        {
            return a * b;
        }
        public double divide(int a, int b)
        {
            return a / b;
        }
    }
}
