using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturos_konverteris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite temperatura laipsniais pagal celsiju");
            double tc = Convert.ToDouble(Console.ReadLine());
            double tk = tc + 273;
            double tf = tc * 18 / 10 + 32;
            Console.WriteLine("Temperatura kelvinais yra: {0}", tk);
            Console.WriteLine("Temperatura farengeitais yra: {0}", tf);
            Console.ReadLine();
        }
    }
}
