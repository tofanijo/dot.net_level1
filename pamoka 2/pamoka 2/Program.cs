using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamoka_2
{
    class Rectangle
    {
        private double length;
        private double width;
        public void Acceptedetails()
        { length = 4.5;
            width = 3.5;
        }
         public double GetArea()
        { return length * width;
        }
        public void Display()
        { Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
                }
            }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptedetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
