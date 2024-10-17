using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Figure
    {
        protected double Area { get; set; }

        public Figure()
        {
            Area = 0;
        }
    }

    public class Triangle : Figure
    {
        private double Base { get; set; }
        private double Height { get; set; }

        public Triangle(double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public double CalculateArea(double Base, double Height)
        {
            return (Base * Height) / 2;
        }

    }

    public class Square : Figure
    {
        private double SideLength { get; set; }

        public Square(double SideLength)
        {
            this.SideLength = SideLength;
        }

        public double CalculateArea(double SideLength)
        {
            return SideLength * SideLength;
        }

    }
}