using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    /// <summary>
    /// Class Circle inheriting from class Figure
    /// </summary>
    class Circle : Figure
    {
        private double r;

        /// <summary>
        /// Circle class constructor
        /// </summary>
        /// <param name="r">Circle radius</param>
        public Circle(double r)
        {
            this.r = r;
        }

        public double R
        {
            get { return r; }
            set { r = value; }
        }

        public override void Info()
        {
            Console.WriteLine($"r= {R}");
        }

        public override double Area()
        {
            return 3.14 * r * r;
        }
    }
}
