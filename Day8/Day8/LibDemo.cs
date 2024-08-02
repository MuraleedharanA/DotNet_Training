using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDemo;

namespace Day8
{
    internal class LibDemo
    {
         public static void Main()
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.sum(1, 2));
            Console.WriteLine(cal.substract(1, 2));
            Console.WriteLine(cal.multiply(1, 2));
            Console.WriteLine(cal.divide(2,2));
        }
        
    }
}
