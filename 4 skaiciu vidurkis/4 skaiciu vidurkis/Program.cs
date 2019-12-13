using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_skaiciu_vidurkis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skaiciu vidurkio skaiciavimas");
            Console.WriteLine("[Pradeti - Enter] [Iseiti -e]");
            while (Console.ReadLine() != "e")

            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Iveskite pirma skaiciu");
                    double sk1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iveskite antra skaiciu");
                    double sk2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iveskite trecia skaiciu");
                    double sk3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iveskite ketvirta skaiciu");
                    double sk4 = Convert.ToDouble(Console.ReadLine());

                    double vidurkis = (sk1 + sk2 + sk3 + sk4) / 4;

                    Console.WriteLine();
                    Console.WriteLine("Ivestu skaiciu vidurkis yra: {0}", vidurkis);
                    Console.WriteLine();
                    Console.WriteLine("[Pakartoti - Enter] [iseiti - e]");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Skaiciu vidurkio saiciavimas");
                    Console.WriteLine("[Pradeti - Enter] [Iseiti - e]");




















                }
            }

        }
    }

}