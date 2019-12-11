using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ivedamu_skaiciu_sandauga_dalyba_skirtumas
{
    class Rectangle
    {
        private double skaicius3;
        private double skaicius2;
        public void Acceptedetails()
        { skaicius3 = 3;
            skaicius2 = 2;
        }
        public double GetArea()
        {
            return skaicius3 * skaicius2;
        }
        public void Display()
        {
            Console.WriteLine("skaicius1: {0}", skaicius3);
            Console.WriteLine("skaicius2: {0}", skaicius2);
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

