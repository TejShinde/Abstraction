using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract public class Shape
    {
        public abstract void CalculateArea();
    }

    public class Circle : Shape
    {
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;
        }

        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }

        public override string ToString()
        {
            return $"Area of circle is {area}";
        }
    }

    public class Rectangle : Shape
    {
        private double length, width, area;

        public Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
        }

        public override void CalculateArea()
        {
            area = length * width;
        }
        public override string ToString()
        {
            return $"Area of Rectangle is {area}";
        }

    }
}
