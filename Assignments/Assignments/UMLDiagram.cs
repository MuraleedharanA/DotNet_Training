using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{   class Shape
    {
        public static Shape operator +(Shape s1)
        {
            return s1;
        }
        public double perimeter(double side, double side2)
        {
            return side * side2;
        }
    }
    class Rectangele : Shape
    {
       protected double side1;
       protected double side2;
    }
    class Circle : Shape
    {
        protected double radius;
    }
    internal class UMLDiagram
    {
    }
}
