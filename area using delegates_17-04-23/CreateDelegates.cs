using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_using_delegates_17_04_23
{
    public delegate void rectangle(double x, double y);
    public delegate void triangle(double x, double y);
    internal class CreateDelegates
    {
        public double RectangleArea(double l, double b)
        {
            return l * b;
        }

        public double TriangleArea(double l, double b)
        {
            return l * b * .5;
        }
    }
    
}
