using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daugybos_lentele
{
    class Program
    {
   
     
    
            static void Main(string[] args)
            {
                Console.WriteLine("Sveiki!");

                string ratas = "";
                Console.WriteLine("skaicius1:");
                ratas = Console.ReadLine();


                string batas = "";
                Console.WriteLine("skaicius2:");
                batas = Console.ReadLine();


                int ratasInt;
                int batasInt = 0;
                int.TryParse(ratas, out ratasInt);
                int.TryParse(batas, out batasInt);
                int balance = ratasInt * batasInt;
               
                Console.WriteLine("Suma:" + balance.ToString());
                Console.ReadLine();
            }
    }
}
