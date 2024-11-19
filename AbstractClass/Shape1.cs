using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Shape1
    {
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

    }

    class Circle1 : Shape1
    {
        private double r;
        private double area;
        private double perimeter;

        public Circle1(double r)
        {
            this.r = r;
        }

        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }
        public override void CalculatePerimeter()
        {
            perimeter = 2 * 3.14 * r;
        }
    }

    class Triangle : Shape1
    {
        private int baseLength,height ;
        private double area;
        private double areaPerimeter;

        public Triangle(int baseLength,int height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }
        public override void CalculateArea()
        {
            area = 0.5 * baseLength * height;
        }

        public override void CalculatePerimeter()
        {
            areaPerimeter = 3 * baseLength;
        }

        public override string ToString()
        {
            return $"Triangle : Area={area},areaPerimeter= {areaPerimeter}";
        }

    }
}
