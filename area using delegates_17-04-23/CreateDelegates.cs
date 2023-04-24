using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_using_delegates_17_04_23
{
    public delegate void rectangle(double x, double y, string yellow);
    public delegate void triangle(double x, double y, string blue);
    public delegate void square(double x, double y, string red);
    public delegate void circle(double x, double y, string Blue)
    internal class CreateDelegates
    {
        public double RectangleArea(double l, double b, string yellow)
        {
            return l * b;
        }

        public double TriangleArea(double l, double b, string blue)
        {
            return l * b * .5;
        }
        public double squareArea(double l, double b, string red)
        {
            return l * b;
        }

        public double CircleArea(double radius, double p, string Blue)
        {
            return p * (radius * radius);

        }
    }
    
}
