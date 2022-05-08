using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Rectangle : Figure
    {
        private double a, b;

        /// <summary>
        /// Rectangle class constructor
        /// </summary>
        /// <param name="a">A side length</param>
        /// <param name="b">B side length</param>
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public override void Info()
        {
            Console.WriteLine($"a= {A} / b= {B}");
        }

        /// <summary>
        /// Inherited method of Figure class
        /// </summary>
        /// <returns>Returns the area of the circle</returns>
        public override double Area()
        {
            return A * B;
        }
    }
}
