using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaiciuotuvas
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double Rezultatas;
            string veiksmas = "";
            while (veiksmas != "exit")
            {
                Console.WriteLine("Iveskite pirma skaiciu:");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("iveskite veiksma [+, -, /, *], arba exit");
                veiksmas = Console.ReadLine();
                Console.WriteLine("Iveskite antra skaiciu:");
                B = Convert.ToDouble(Console.ReadLine());
                

                switch (veiksmas)
                {

                    case "+":
                        Rezultatas = A + B;
                        RodytiRezultata(Rezultatas);
                        break;
                    case "-":
                        Rezultatas = A - B;
                        RodytiRezultata(Rezultatas);
                        break;
                    case "/":
                        Rezultatas = A / B;
                        RodytiRezultata(Rezultatas);
                        break;
                    case "*":
                        Rezultatas = A * B;
                        RodytiRezultata(Rezultatas);
                        break;
                    case "exit":
                        Console.WriteLine("Viso gero!");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Neteisingai ivestas veiksmas, pakartokite");
                        break;
                }
            }
            void RodytiRezultata(double aRezultatas)
            {
                {
                    Console.WriteLine("Rezultatas yra : {0}", aRezultatas);




                }

            }
        }
    }
}

