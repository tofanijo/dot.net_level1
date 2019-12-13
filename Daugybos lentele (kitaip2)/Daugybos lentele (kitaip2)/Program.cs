using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daugybos_lentele__kitaip2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius;
            int rezultatas;
            string klaviatura = "";

            while (klaviatura != "exite")
            {
                Console.WriteLine();
                Console.WriteLine("iveskite sveika skaiciu nuo 1 iki 3 [ Iseiti - exit]");
                klaviatura = Console.ReadLine();

                switch (klaviatura)
                {
                    case "1":
                        skaicius = Convert.ToInt32(klaviatura);
                        IsvestiLentele(skaicius);
                        break;
                    case "2":
                        skaicius = Convert.ToInt32(klaviatura);
                        IsvestiLentele(skaicius);
                        break;
                    case "3":
                        skaicius = Convert.ToInt32(klaviatura);
                        IsvestiLentele(skaicius);
                        break;

                    case "exit":
                        Console.WriteLine("Viso gero!");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Neteisingas skaicius, bandykite dar karta:");
                        break;
                }
                void IsvestiLentele(int aSkaicius)
                {
                    Console.WriteLine("Ivesto skaiciaus daugybos lenetele:");

                    for (int i = 1; i < 11; i++)
                    {
                        rezultatas = aSkaicius * i;
                        Console.WriteLine(skaicius + " x " + i + " = " + rezultatas);

                    }


                }
            }
        }
    }
}


    

