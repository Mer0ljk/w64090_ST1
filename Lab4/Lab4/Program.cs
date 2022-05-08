using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> list1 = new List<Figure>();

            Rectangle rectangle1 = new Rectangle(5, 10);
            Rectangle rectangle2 = new Rectangle(2, 8);

            Circle circle1 = new Circle(7);
            Circle circle2 = new Circle(9);

            rectangle1.Info();
            Console.WriteLine(rectangle1.Area() + "\n");

            circle1.Info();
            Console.WriteLine(circle1.Area() + "\n");

            list1.Add(rectangle1);
            list1.Add(rectangle2);
            list1.Add(circle1);
            list1.Add(circle2);

            foreach(var p in list1)
            {
                if(p.Area() > 40)
                {
                    p.Info();
                }
            }
        }
    }
}
